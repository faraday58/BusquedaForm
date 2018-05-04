using System;

namespace MetodosBusqueda
{
    public class Busqueda
    {
        public int Binaria(int []V,int X)
        {
            int N = V.Length;
            int IZQ = 0;
            int DER = N;
            int CEN = (IZQ + DER) / 2;
            bool BanNoEncuentra = true;

            while( IZQ < DER && BanNoEncuentra)
            {
                if( V[CEN] == X)
                {
                    BanNoEncuentra = false;

                }
                else if( V[CEN]> X  )
                {
                    DER = CEN;

                    CEN = (IZQ + DER) / 2;
                }
                else
                {
                    IZQ = CEN+1;
                    CEN = (IZQ + DER) / 2;

                }

            }
            if(BanNoEncuentra)
            {
                return -1;
            }
            else
            {
                return CEN;
            }

        }

    }
}
