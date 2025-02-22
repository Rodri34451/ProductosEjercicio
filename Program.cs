﻿using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;

namespace hoy;

class Program
{
    static void Main(string[] args)
    {
        Producto producto1 = new Producto();
        Producto producto2 = new Producto("CSDA", "eeee");
        Console.WriteLine(producto2.GetPrecio());

        Console.WriteLine("Nombre, precio y stock del primer producto");
        Console.WriteLine(producto1.GetNombre());
        Console.WriteLine(producto1.GetPrecio());
        Console.WriteLine(producto1.GetStock());

        Console.WriteLine("\nNombre, preico y stock del segundo producto");
        Console.WriteLine(producto2.GetNombre());
        Console.WriteLine(producto2.GetPrecio());
        Console.WriteLine(producto2.GetStock());

        producto1.SetPrecio(-100);
        producto2.SetStock(-1);

        Console.WriteLine("\nDatos finales del primer producto:");
        Console.WriteLine(producto1.GetCodigo());
        Console.WriteLine(producto1.GetNombre());
        Console.WriteLine(producto1.GetPrecio());
        Console.WriteLine(producto1.GetStock());

        Console.WriteLine("\nDatos finales de segundo producto:");
        Console.WriteLine(producto2.GetCodigo());
        Console.WriteLine(producto2.GetNombre());
        Console.WriteLine(producto2.GetPrecio());
        Console.WriteLine(producto2.GetStock());
    }
}

class Producto
{
    //Atributos
    private string codigo;
    private string nombre;
    private double precio;
    private int stock;

//Constructor por defecto
    public Producto()
    {
        codigo = "";
        nombre = "Sin nombre";
        precio = 0;
        stock = 0;
    }

//Constructor con parametros
    public Producto(string codigo, string nombre)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.precio = 0;
        this.stock = 0;
    }

//Metodos Set
    public void SetCodigo(string codigo)
    {
        this.codigo = codigo;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void SetPrecio(double precio)
    {
        if (precio < 0)
        {
            Console.WriteLine("El precio no puede ser menor a 0");
        }
        else
        {
            this.precio = precio;
        }    
    }

    public void SetStock(int stock)
    {
        if (stock < 0)
        {
            Console.WriteLine("El stock no puede ser menor a 0");
        }
        else
        {
            this.stock = stock;

        }
    }

//Metodos Get
    public string GetCodigo()
    {
        return codigo;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public double GetPrecio()
    {
        return precio;
    }

    public int GetStock()
    {
        return stock;
    }
}