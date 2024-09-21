using BodegaDeVinosProyect.Entities;
using System;

public class PrincipalRepository
{
    // Lista en memoria de vinos
    private List<Wine> wines = new List<Wine>();

    // Lista en memoria de usuarios
    private List<User> users = new List<User>();

    // Métodos para gestionar la lista de vinos
    public List<Wine> GetWines() => wines;
    public void AddWine(Wine wine) => wines.Add(wine);

    // Métodos para gestionar la lista de usuarios
    public List<User> GetUsers() => users;
    public void AddUser(User user) => users.Add(user);
}
