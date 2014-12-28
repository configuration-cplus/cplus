using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.PackageDB
{
   public class IncrementDB_BAO : IncrementDB_DAO
    {

       private string GenererCode(IncrementationDB incrementation) {
           DateTime date = DateTime.Now;
           string Code = date.Year.ToString() + date.Month + date.Day + date.Hour + date.Minute + date.Second + "-" + incrementation.Titre.Trim();
           return Code;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="IncDB"></param>
       /// <exception cref="IOException">This exception is thrown if the archive already exists</exception>
       public void Execut(IncrementationDB incrementation)   
       {
           incrementation.DateCreation = DateTime.Now;
           incrementation.Code = this.GenererCode(incrementation);
           base.Execut(incrementation);
       }

       /// <summary>
       /// Enregistrer la requ$ete sans le ficier XML sans l'excuter dans la base de données
       /// </summary>
       /// <param name="incrementation"></param>
       public void SaveWithOutExecut(IncrementationDB incrementation)
       {
           incrementation.DateCreation = DateTime.Now;
           incrementation.Code = this.GenererCode(incrementation);
           base.SaveWithOutExecut(incrementation);
       }



       public   void Update(IncrementationDB incrementation)
       {
           incrementation.Code = this.GenererCode(incrementation);
           base.Update(incrementation);
       }
    }
}
