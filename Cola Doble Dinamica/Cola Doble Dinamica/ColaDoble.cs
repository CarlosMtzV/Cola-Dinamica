using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_Doble_Dinamica
{
    public class ColaDoble<T>
    {
        private Nodo<T> frente;
        private Nodo<T> final;


        public ColaDoble()
        {

            frente = null;
            final = null;
        }

       
        public bool EstaVacia()
        {
            return frente == null;
        }

        // Insertar al frente
        public void InsertarFrente(T valor)
        {
            Nodo<T> nuevo = new Nodo<T>(valor);
            if (EstaVacia())
            {
                frente = final = nuevo;
            }
            else
            {
                nuevo.Siguiente = frente;
                frente.Anterior = nuevo;
                frente = nuevo;
            }
        }

        // Insertar al final
        public void InsertarFinal(T valor)
        {
            Nodo<T> nuevo = new Nodo<T>(valor);
            if (EstaVacia())
            {
                frente = final = nuevo;
            }
            else
            {
                nuevo.Anterior = final;
                final.Siguiente = nuevo;
                final = nuevo;
            }
        }

        // Eliminar del frente
        public T EliminarFrente()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            T valor = frente.Valor;
            if (frente == final)
            {
                frente = final = null;
            }
            else
            {
                frente = frente.Siguiente;
                frente.Anterior = null;
            }
            return valor;
        }

        // Eliminar del final
        public T EliminarFinal()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            T valor = final.Valor;
            if (frente == final)
            {
                frente = final = null;
            }
            else
            {
                final = final.Anterior;
                final.Siguiente = null;
            }
            return valor;
        }

        // Acceder al frente
        public T VerFrente()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            return frente.Valor;
        }

        // Acceder al final
        public T VerFinal()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            return final.Valor;
        }


        public List<T> ObtenerElementos()
        {
            List<T> elementos = new List<T>();
            Nodo<T> actual = frente;

            while (actual != null)
            {
                elementos.Add(actual.Valor);
                actual = actual.Siguiente;
            }

            return elementos;
        }
    }
}
