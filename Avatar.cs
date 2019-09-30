using System;
using System.Collections.Generic;
public class Avatar{
  public string nome
  {
    get; set;
  }
  public int hp
  {
    get; set;
  }
  public int att{
    get; set;
  }
  public int mp
  {
    get; set;
  }
  public int mag{
    get; set;
  }

  private List<string> type{
    get; set;
  }

  public Avatar(string nome, int hp, int att, int mp, int mag){
    this.nome = nome;
    this.hp = hp;
    this.att = att;
    this.mp = mp;
    this.mag = mag;

  }
  public Avatar()
  {

  }

  //TODO: Criar os Tipos
  public void addTipos()
  {
    type.Add("FIRE");
    type.Add("WATER");
    type.Add("EARTH");
  }

  //TODO: Atacar
  public int attack()
  {
    int damage = att;
    return damage;
  }


  //TODO: Menu de Ações
  public int showMenu()
  {
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("HP: " + hp);
    Console.WriteLine("MP:" + mp);
    Console.WriteLine("- - - - - - -");
    Console.WriteLine("1 - Attack");
    Console.WriteLine("2 - Heal");
    int i = int.Parse(Console.ReadLine());
    return i;
  }


}