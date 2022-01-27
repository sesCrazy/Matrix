using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Матрица
{
    class Matr
    {
        public static bool ZeroMatr (DataGridView data, NumericUpDown numeric)
        {
            int num = Convert.ToInt32(numeric.Value);

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (Convert.ToInt32(data[i, j].Value) != 0) return false;
                }
            }
            return true;
        }

        public static bool UnitMatr (DataGridView data, NumericUpDown numeric)
        {
            int num = Convert.ToInt32(numeric.Value);

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == j)
                    {
                        if (Convert.ToInt32(data[i, j].Value) != 1) return false;
                    }
                    else
                    {
                        if (Convert.ToInt32(data[i, j].Value) != 0) return false;
                    }
                }
            }
            return true;
        }

        public static bool DiagonalMatr(DataGridView data, NumericUpDown numeric)
        {
            int num = Convert.ToInt32(numeric.Value);

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == j)
                    {
                        if (Convert.ToInt32(data[i, j].Value) == 0) return false;
                    }
                    else
                    {
                        if (Convert.ToInt32(data[i, j].Value) != 0) return false;
                    }

                }
            }
            return true;
        }
    }
}
