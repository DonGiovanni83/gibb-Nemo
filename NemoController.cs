using System;

namespace Nemo
{
    class NemoController
    {
        private NemoModel Model;
        private NemoForm View;

        public NemoController(NemoModel model, NemoForm view)
        {
            this.Model = model;
            this.View = view;

            this.View.SetInfoText(this.Model.GetInfoIdle());
            this.SubscribeView();
        }

        private void SubscribeView()
        {
            this.View.AddStartButtonClickHandler(new EventHandler(this.ClickOnStart));
            this.View.AddStopButtonClickHandler(new EventHandler(this.ClickOnStopt));
            this.View.AddRestartButtonClickHandler(new EventHandler(this.ClickOnRestart));

            this.View.SetOnTickAction(new EventHandler(this.HandleTick));
        }

        public void HandleTick(object sender, EventArgs e)
        {
            this.UpdateGame();
            this.RenderBoard();
        }
        private void ClickOnStart(object sender, EventArgs e) {
            this.View.StartGameTimer();
            this.View.DisableStartButton();
            this.View.EnableStopButton();
            this.Model.IncreaseGameCount();
            this.View.SetInfoText(this.Model.GetInfoRunning());
        }
        private void ClickOnStopt(object sender, EventArgs e) {
            this.View.StopGameTimer();
            this.View.DisableStopButton();
            this.View.EnableRestartButton();
            this.View.SetInfoText(this.Model.GetInfoErrorStopped());
        }
        private void ClickOnRestart(object sender, EventArgs e) {
            this.View.DisableRestartButton();
            this.View.EnableStartButton();
            this.View.SetInfoText(this.Model.GetInfoIdle());
            this.View.ClearBoard();
        }

        private void UpdateGame()
        {
            foreach (Tile tile in this.Model.GetGameBoardCopy())
            {
                this.MoveSingleTile(tile);
            }
            this.CreateNewTilesIfNecessary();
        }

        private void MoveSingleTile(Tile tile)
        {
            tile.MoveDown(this.Model.GetGameSpeed());

            if (!this.TileIsInBoardRange(tile))
            {
                this.Model.RemoveTile(tile);
            }
        }

        private bool TileIsInBoardRange(Tile tile)
        {
            return this.View.GetBoardHeight() + 92 > tile.GetY();
        }

        private void CreateNewTilesIfNecessary()
        {
            if (this.NewTileRowRequired())
            {
                this.Model.CreateNewTileRow();
            }
        }

        private bool NewTileRowRequired()
        {
            // First find the y value of the tile row on top
            int currentMinY = 0;
            foreach (Tile tile in this.Model.GetGameBoard())
            {
                if (currentMinY > tile.GetY())
                {
                    currentMinY = tile.GetY();
                }
            }

            // A new tile is required if the current minimal Y is >= 0
            return currentMinY >= 0;
        }

        public void RenderBoard()
        {
            foreach (Tile tile in this.Model.GetGameBoardCopy())
            {
                this.View.RenderTile(
                    tile.GetValue(),
                    tile.GetX(),
                    tile.GetY(),
                    tile.GetBackground()
                    );
            }
        }
    }
}
