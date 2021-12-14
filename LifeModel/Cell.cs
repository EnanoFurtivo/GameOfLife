using System.Collections.Generic;
using System.Linq;

namespace LifeModel
{
    public class Cell
    {
        public bool IsAlive;
        private bool IsAliveNext;

        public readonly List<Cell> neighbors = new List<Cell>();

        public void DetermineNextLiveState(ref int deaths, ref int births, ref int alive, ref int dead)
        {
            int liveNeighbors = neighbors.Where(x => x.IsAlive).Count();

            if (IsAlive)
            {
                if (liveNeighbors == 2 || liveNeighbors == 3)
                {
                    alive++;
                    IsAliveNext = true;
                }
                else
                {
                    deaths++;
                    dead++;
                    IsAliveNext = false;
                }
            }
            else
            {
                if (liveNeighbors == 3)
                {
                    alive++;
                    births++;
                    IsAliveNext = true;
                }
                else
                {
                    dead++;
                    IsAliveNext = false;
                }
            }
        }

        public void Advance()
        {
            IsAlive = IsAliveNext;
        }
    }
}
