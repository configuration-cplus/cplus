using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using CompetencePlus.Outils;
using CompetencePlus.PackageFilieres;
using CompetencePlus.Tools;

namespace CompetencePlus.PackageGroupes
{
    public class GroupeDAO : IGestion<Groupe>
    {
        public  void Add(Groupe g)
        {
            string Requete = "Insert into Groupes(Nom,Code,Description,idFiliere) values ('" +g.Nom  + "','" +g.Code+ "','" + g.Description +"',"+g.Filiere.Id +")";
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  void Update(Groupe g)
        {
            string Requete = "Update Filieres set Code ='" + g.Code + "',Nom ='" + g.Nom +"',Description='"+g.Description+"',IdFiliere="+g.Filiere.Id+" where id =" + g.Id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  void Delete(int id)
        {
            string Requete = "Delete From Groupes where id=" + id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  List<Groupe> Select()
        {
            string Requete = "Select * from Groupes";
            List<Groupe> ListGroupe = new List<Groupe>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                Groupe g = new Groupe();
                g.Id = read.GetInt32(0);
                g.Nom = read.GetString(1);
                g.Code = read.GetString(2);
                g.Description = read.GetString(3);
                g.Filiere = new FiliereDAO().FindById(read.GetInt32(4));
                ListGroupe.Add(g);

            }
            MyConnection.Close();
            return ListGroupe;
        }

        public Groupe FindById(int id)
        {
            string Requete = "Select * from Groupes where id="+id;
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            Groupe g = new Groupe();
            read.Read();
            g.Id = read.GetInt32(0);
            g.Code = read.GetString(1);
            g.Nom = read.GetString(2);
            g.Filiere = new FiliereDAO().FindById(read.GetInt32(3));
            MyConnection.Close();
            return g; 
        }
        public Groupe FindByName(string Name)
        {
            string Requete = "Select * from Groupes where Nom='"+Name+"'";
       
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            read.Read();
            Groupe g = new Groupe();
            g.Id = read.GetInt32(0);
            g.Code = read.GetString(1);
            g.Nom = read.GetString(2);
            g.Filiere = new FiliereDAO().FindById(read.GetInt32(3));
            MyConnection.Close();
            return g;
        }

        public List<Groupe> FindByGroup(Groupe g) {
            string Requete = "Select * from Groupes ";
            if (g.Code != "" || g.Nom != "" || g.Description != ""||g.Filiere.Titre!="")
            {
                Requete += " where ";
            }
            bool and = false;
            if (g.Code != "")
            {
                Requete += " Code like '%" + g.Code + "%'";
                and = true;
            }
            if (g.Nom != "")
            {
                if (and) Requete += " and ";
                Requete += " Nom like '%" + g.Nom + "%'";
                and = true;
            }
            if (g.Description != "")
            {
                if (and) Requete += " and ";
                Requete += " Description like '%" + g.Description + "%'";
                and = true;
            }
            if (g.Filiere.Titre != "")
            {
                if (and) Requete += " and ";
                Requete += " IdFiliere like '%" + g.Filiere.Id + "%'";
                and = true;
            }

            List<Groupe> ListGroupe = new List<Groupe> ();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                Groupe gr = new Groupe();
                gr.Id = read.GetInt32(0);
                gr.Nom = read.GetString(1);
                gr.Code = read.GetString(2);
                gr.Description = read.GetString(3);
                gr.Filiere = new FiliereDAO().FindById(read.GetInt32(4));
                ListGroupe.Add(gr);
            }
            MyConnection.Close();
            return ListGroupe;
        }
         
    }
}
