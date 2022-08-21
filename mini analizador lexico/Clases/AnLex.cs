using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_analizador_lexico.Clases
{
    public class AnLex
    {
        public static string analizar(string cadena)
        {
            int estado = 0, fin = cadena.Length;
            
            for(int i=0; i<fin; i++)
            {
                if (cadena[i] == ' ' || cadena[i] == ';' ) estado = 0;
                else if (estado == 0)
                {
                    if (cadena[i] >= 'a' && cadena[i] <= 'z' || cadena[i] >= 'A' && cadena[i] <= 'Z')
                        estado = 1;
                    else if (cadena[i] >= '0' && cadena[i] <= '9')
                        estado = 2;
                    else estado = 4;
                }
                else if (estado == 1)
                {
                    if (cadena[i] >= 'a' && cadena[i] <= 'z'
                        || cadena[i] >= 'A' && cadena[i] <= 'Z'
                        || cadena[i] >= '0' && cadena[i] <= '9')
                        estado = 1;
                    else estado = 4;
                }
                else if (estado == 2)
                {
                    if (cadena[i] >= '0' && cadena[i] <= '9')
                        estado = 2;
                    else if (cadena[i] == '.')
                        estado = 3;
                    else estado = 4;
                }
                else if (estado == 3)
                {
                    if (cadena[i] >= '0' && cadena[i] <= '9')
                        estado = 2;
                    else estado = 4;
                }
                else if (estado == 4)
                {
                    break;
                }
            }

            if (estado == 1) return "Identificador";
            else if (estado == 2) return "Numero real";
            else return "Error";  
        }
    }
}
