using System;
using System.Collection.Generic;
using DiO.Series.Interfaces;

namespace DIO.Series.Classes
{
    public class SerieRepositorio : iRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie objeto){
            listaSerie[id] = objeto;
        }

        public void Exclui(int id){
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto){
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista(){
            return listaSerie;
        }

        public int ProximoId(){
            return listaSerie.count;
        }

        public Serie RetornaPorId(int id){
            return listaSerie[id];
        }


    }
}