using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiDcore
{
  // K/V single-to-many container
  public class MultiMap<_Key, _Value>
  {
    internal Dictionary<_Key, List<_Value>> map;
    internal Int32 InitialListSize = 16;

    public MultiMap()
    {
      map = new Dictionary<_Key, List<_Value>>(16);
    }

    public MultiMap(Int32 initialDictionarySize, Int32 initialListSize)
    {
      map = new Dictionary<_Key, List<_Value>>(initialDictionarySize);
      InitialListSize = initialDictionarySize;
    }

    public void Clear()
    {
      map.Clear();
    }

    public void Add(_Key key, _Value value)
    {
      List<_Value> list;
      if (map.TryGetValue(key, out list))
      {
        list.Add(value);
      }
      else
      {
        list = new List<_Value>(InitialListSize);
        list.Add(value);
        map[key] = list;
      }
    }

    public IEnumerable<_Key> Keys
    {
      get
      {
        return map.Keys;
      }
    }

    public List<_Value> this[_Key key]
    {
      get
      {
        List<_Value> list;
        if (map.TryGetValue(key, out list))
        {
          return list;
        }
        else
        {
          return new List<_Value>(InitialListSize);
        }
      }
    }
  }
}
