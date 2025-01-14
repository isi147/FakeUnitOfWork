﻿using ConsoleApp9.Models;

namespace ConsoleApp9.Repository.Abstract;

public interface IItemRepository
{
    public void Add(Item product);
    public void Update(int id);
    public void Delete(int id);
    public Item GetById(int id);
    public List<Item> GetAll();
}
