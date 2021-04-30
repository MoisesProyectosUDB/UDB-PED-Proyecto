﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED.Estructuras.ABL
{
   
        class Arbol<Tipo>
        {
            private Arbol<Tipo> padre;
            private Tipo valor;
            private List<Arbol<Tipo>> hijos;

            /**
           * Construye un Nuevo Nodo estableciendo a un padre y con un valor inicial     
           */
            public Arbol(Arbol<Tipo> padre, Tipo valor)
            {
                this.padre = padre;
                this.valor = valor;
                hijos = new List<Arbol<Tipo>>();///los hijos se devuelven en una lista
            }


            public void setValor(Tipo valor) //Modifica el Valor
            {
                this.valor = valor;
            }
            public Tipo getValor() //obtiene el valor  "Paciente","Genero",etc
            {
                return valor;
            }

            public void agregarHijo(Arbol<Tipo> hijo) //agrega hijos al nodo<Tipo>
            {
                hijos.Add(hijo);
            }
            public List<Arbol<Tipo>> getHijos()//Devuelve una lista de los hijos del  nodo<Tipo>
            {
                return this.hijos;
            }

            public Arbol<Tipo> getPadre()//  Devuelve el nodo padre
            {
                return this.padre;
            }

        }
    
}
