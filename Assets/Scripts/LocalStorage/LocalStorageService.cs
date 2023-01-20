using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public enum GameEntity
{
  player,
  interactions
}

public class LocalStorageService
{
  private string storagePath;
  private string fullPath;

  public LocalStorageService(GameEntity entity)
  {
    this.storagePath = $"/LocalStorage/{entity}.json";
    this.fullPath = Application.dataPath + storagePath;
  }

  public List<T> GetAll<T>()
  {
    if (File.Exists(fullPath))
    {
      string data = File.ReadAllText(fullPath);
      ObjectListDto<T> objectList = JsonUtility.FromJson<ObjectListDto<T>>(data);
      return objectList.items;
    }
    return null;
  }

  public T Get<T>()
  {
    ObjectDto<T> obj = new ObjectDto<T>();
    if (File.Exists(fullPath))
    {
      string data = File.ReadAllText(fullPath);
      obj = JsonUtility.FromJson<ObjectDto<T>>(data);
      return obj.entity;
    }
    return obj.entity;
  }

  public void Post<T>(T t)
  {
    ObjectDto<T> obj = new ObjectDto<T>();
    if (File.Exists(fullPath))
    {
      obj.entity = t;
      string jsonData = JsonUtility.ToJson(obj, true);
      File.WriteAllText(fullPath, jsonData);
    }
  }
}
