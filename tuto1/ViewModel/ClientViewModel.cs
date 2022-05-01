using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using tuto1.model;

namespace tuto1.ViewModel
{
    class ClientViewModel : INotifyPropertyChanged
    {
        Donnee db = new Donnee();
        private client _Model;
        private List<client> lesClients;
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
            //MessageBox.Show(db.clients.ToString());
        }
        public ClientViewModel()
        {
            GetLesClients();
        }
        public client getLeClient(int i)
        {
            var cli = from cat in db.clients
                      where cat.code_c == i
                      select cat;
            this._Model = cli.ToList()[0];
            return this._Model;
        }
        public client getLeClient()
        {
            return this._Model;
        }
        public void setLeClient(client lecli)
        {
            this._Model = lecli;
            OnPropertyChanged();
        }
        public List<client> GetLesClients()
        {
            var cli = from cat in db.clients
                      select cat;
            this.lesClients = cli.ToList();
            return this.lesClients;
        }
        public void SetLesClients(List<client> lesClis)
        {
            lesClients = lesClis;
            OnPropertyChanged();
        }
        public void Update(client leClient)
        {
            MessageBox.Show(leClient.code_c + " " + leClient.nom);
            for (int i = 0; i < db.clients.ToList().Count; i++)
            {
                if (db.clients.ToList()[i].code_c == leClient.code_c)
                {
                    db.clients.ToList()[i] = leClient;
                }
            }
            SetLesClients(GetLesClients());
            db.SaveChanges();
        }
        public bool Delete(client leClient)
        {
            bool test = false;
            int nbre = db.clients.ToList().Count;
            foreach (client a in db.clients.ToList())
            {
                if (a.code_c == leClient.code_c)
                {
                    db.clients.Remove(leClient);
                    GetLesClients().Remove(leClient);
                    break;
                }
            }
            db.SaveChanges();
            SetLesClients(GetLesClients());
            if (db.clients.ToList().Count < nbre)
            {
                MessageBox.Show($"Le client {leClient.nom} a bien été effacé!");
                test = true;
            }
            return test;
        }
        public bool Insert(client leClient)
        {
            bool test = false;
            int nbre = db.clients.ToList().Count;
            //MessageBox.Show("avant : " + nbre);
            db.clients.Add(leClient);
            GetLesClients().Add(leClient);
            db.SaveChanges();
            //db.SaveChangesAsync();
            //MessageBox.Show("apres : " + db.clients.ToList().Count);
            SetLesClients(GetLesClients());
            if (db.clients.ToList().Count > nbre)
            {
                MessageBox.Show($"Le client {leClient.nom} a bien été enregistré!");
                test = true;
            }
            return test;
        }
    
        public ICollection<commande> GetCommandesClient()
        {
            return this._Model.commandes;
        }
        public void SetCommandesClient(ICollection<commande> lesCom)
        {
            this._Model.commandes = lesCom;
            OnPropertyChanged();
        }
    }
}

