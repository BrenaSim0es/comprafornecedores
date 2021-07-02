
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Aula14

{

    class Compra

    {

        Carrinho _produtos;

        Estoque _estoque;

        public Carrinho Produtos

        {



            get

            {

                return _produtos;

            }



        }

        public Estoque Estoque

        {



            get

            {

                return _estoque;

            }



        }

        public Compra(Carrinho produtos, Estoque estoque) 

        {



            this._estoque = estoque;

            this._produtos = produtos;

            

        }

        public void F_Dinero() 

        {

        

            foreach(KeyValuePair<Produto, int> pair in this._produtos.Itens) 

            {



                if (this._estoque.Itens.ContainsKey(pair.Key) && this._estoque.Itens[pair.Key] >= this._produtos.Itens[pair.Key]) 

                {

                    

                    this._estoque.Itens[pair.Key] -= pair.Value;

                    Console.WriteLine("Comprado " + pair.Key.Nome);

                

                }



            }

        

        }



    }

}





ESTOQUE :



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



FORNECEDOR:



using System;

using System.Collections.Generic;



public class Fornecedor

{



    private string _nome;

    private string _cpf;

    private Estoque _estoque;



    public string Nome

    {

        get

        {

            return this._nome;

        }

    }



    public string Cpf

    {

        get

        {

            return this._cpf;

        }

    }



    public string Estoque

    {

        get

        {

            return this._estoque;

        }

    }

    public Fornecedor(string nome, string cpf, Estoque estoque) 

    {

        this._cpf = cpf;

        this._nome = nome;

        this._estoque = estoque;

    }



    public void Fornecer(Produto produto, int quantidade) 

    {



        this._estoque.Adicionar(produto, quantidade);

        

    }

    public void Fornecer(List<Produto> produtos, int quantidade)

    {

        foreach (Produto produto in produtos)

        {

            this._estoque.Adicionar(produto, quantidade);

        }

    }






}

Mostrar mais ...



COMPRA:





using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Aula14

{

    class Compra

    {

        Carrinho _produtos;

        Estoque _estoque;

        public Carrinho Produtos

        {



            get

            {

                return _produtos;

            }



        }

        public Estoque Estoque

        {



            get

            {

                return _estoque;

            }



        }

        public Compra(Carrinho produtos, Estoque estoque) 

        {



            this._estoque = estoque;

            this._produtos = produtos;

            

        }

        public void F_Dinero() 

        {

        

            foreach(KeyValuePair<Produto, int> pair in this._produtos.Itens) 

            {



                if (this._estoque.Itens.ContainsKey(pair.Key) && this._estoque.Itens[pair.Key] >= this._produtos.Itens[pair.Key]) 

                {

                    

                    this._estoque.Itens[pair.Key] -= pair.Value;

                    Console.WriteLine("Comprado " + pair.Key.Nome);

                

                }



            }

        

        }



    }

}

