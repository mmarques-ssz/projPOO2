using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projPOO2
{
    class Contador
    {
        #region Atributos
        private int valor; // ReadOnly
        #endregion

        #region Construtores
        public Contador()
        {
            this.valor = 0;
        }

        public Contador(int valor)
        {
            this.valor = valor;
        }
        #endregion

        #region Métodos Setters & Getters
        public int getValor()
        {
            return this.valor;
        }
        #endregion

        #region Métodos Funcionais
        // Sobrecarregado (overload)
        public void adicionar()
        {
            this.valor++;
        }
        // Sobrecarregado (overload)
        public void adicionar(int valor)
        {
            this.valor += valor;
        }
        // Sobrecarregado (overload)
        public void subtrair()
        {
            this.valor--;
        }
        // Sobrecarregado (overload)
        public void subtrair(int valor)
        {
            this.valor -= valor;
        }

        public void zerar()
        {
            this.valor = 0;
        }
        #endregion
    }
}
