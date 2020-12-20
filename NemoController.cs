using System;
using System.Windows.Forms;

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

            this.Model.CreateNewBoard(5, 5, this.View.GetBoardWidth(), this.View.GetBoardHeight());
            this.View.SetInfoText(this.Model.GetInfoIdle());
            this.SubscribeView();            
        }

        private void SubscribeView()
        {
            this.View.AddStartButtonClickHandler(new EventHandler(this.ClickOnStart));
            this.View.AddStopButtonClickHandler(new EventHandler(this.ClickOnStop));
            this.View.AddRestartButtonClickHandler(new EventHandler(this.ClickOnRestart));
            this.View.AddClickOnWrongTileHandler(new EventHandler(this.ClickOnWrongTile));
            this.View.AddClickOnRedTileCallback(this.ClickOnRedTile);

            this.View.SetOnTickAction(new EventHandler(this.HandleTick));
        }

        public void HandleTick(object sender, EventArgs e)
        {
            this.UpdateGame();
            this.RenderBoard();
            this.CheckBoard();
        }

        private void ClickOnStart(object sender, EventArgs e) {
            this.View.StartGameTimer();
            this.View.DisableStartButton();
            this.View.EnableStopButton();
            this.View.SetInfoText(this.Model.GetInfoRunning());
        }

        private void ClickOnStop(object sender, EventArgs e) {
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
            this.Model.ResetGame();
        }

        private void ClickOnWrongTile(object sender, EventArgs e)
        {
            this.View.StopGameTimer();
            this.View.DisableStopButton();
            this.View.EnableRestartButton();
            this.View.SetInfoText(this.Model.GetInfoErrorClick());
        }

        private void ClickOnRedTile(int value)
        {
            this.Model.AddPoints(value);
            this.Model.IncreaseSpeed();
        }

        private void UpdateGame()
        {
            foreach (TileRow row in this.Model.GetGameBoardCopy())
            {
                this.MoveSingleTileRow(row);
            }
            this.CreateNewTilesIfNecessary();
        }

        private void MoveSingleTileRow(TileRow row)
        {
            row.MoveDown(this.Model.GetGameSpeed());

            if (!this.TileRowIsInBoardRange(row))
            {
                this.Model.RemoveTileRow(row);
            }
        }

        private bool TileRowIsInBoardRange(TileRow row)
        {
            return this.View.GetBoardHeight() + this.Model.TileHeight > row.Y;
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
            foreach (TileRow tileRow in this.Model.GameBoard)
            {
                if (currentMinY > tileRow.Y)
                {
                    currentMinY = tileRow.Y;
                }
            }

            // A new tile is required if the current minimal Y is >= 0
            return currentMinY >= 0;
        }

        private void RenderBoard()
        {
            foreach (TileRow tileRow in this.Model.GetGameBoardCopy())
            {
                foreach (Tile tile in tileRow.Tiles)
                {
                    this.View.RenderTile(
                        tile.Value,
                        tile.X,
                        tile.Y,
                        tile.Width,
                        tile.Height,
                        tile.Background
                        );
                }
            }
        }

        private void CheckBoard()
        {
            if (this.View.BoardContainsMissedRedTiles())
            {
                this.View.StopGameTimer();
                this.View.DisableStopButton();
                this.View.EnableRestartButton();
                this.View.SetInfoText(this.Model.GetInfoErrorMissed());
            }
        }
    }
}
