
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Aula14

{

    class Estoque

    {

        private Dictionary<Produto, int> _itens;



        public Dictionary<Produto, int> Itens

        {

            get { return this._itens; }

        }

                

        public Estoque()

        {

            this._itens = new Dictionary<Produto, int>();

        }



        public void Adicionar(Produto item, int quantidade)

        {

            if (this._itens.ContainsKey(item))

                this._itens[item] = this._itens[item] + quantidade;

            else

                this._itens[item] = quantidade;

        }



        public void Adicionar(Produto item)

        {

            this.Adicionar(item, 1);

        }



        public void Adicionar(List<Produto> itens)

        {

            foreach (var item in itens)

            {

                this.Adicionar(item);

            }

        }



        public void Adicionar(Dictionary<Produto, int> itens)

        {

            foreach (KeyValuePair<Produto, int> parOrdenado in itens)

            {

                this.Adicionar(parOrdenado.Key, parOrdenado.Value);

            }

        }



        public void ImprimirEstoque()

        {

            Console.WriteLine("======== Estoque ========");

            foreach (KeyValuePair<Produto, int> parOrdenado in this._itens)

            {

                parOrdenado.Key.Imprimir();

                Console.WriteLine("Quantidade:\t{0}", parOrdenado.Value);

                Console.WriteLine("==========================");

            }

            

        }

    }


}
