using System;
using System.Collections.Generic;
using System.Text;
using CompanyManagement.Models;
using CompanyManagement.Utilities;

namespace CompanyManagement.Servicees
{
    internal class ClientRepository
    {
        public Dictionary<Guid, Client> Clients = new Dictionary<Guid, Client>();

        void AddClient(Client client)
        {
            Clients.Add(client.Id, client);
        }

        Client? GetClientById(Guid id)
        {
            return Clients[id];
        }

        List<Client> GetAllCLients()
        {
            List<Client> AllClients = new List<Client>();

            foreach (KeyValuePair<Guid, Client> client in Clients)
            {
                AllClients.Add(client.Value);
            }

            return AllClients;
        }

        List<Client> GetActiveCLients()
        {
            List<Client> ActiveClients = new List<Client>();

            foreach (KeyValuePair<Guid, Client> client in Clients)
            {
                if (client.Value.IsActive) ActiveClients.Add(client.Value);
            }

            return ActiveClients;
        }
    }
}
