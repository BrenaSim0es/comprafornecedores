Using System;

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
