import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Genre
{
  private Map<String, Integer> mufajok = new HashMap<>();

  public void register (List<String> lista)
  {
    for (String s : lista)
    {
      mufajok.put(s,mufajok.getOrDefault(s, 0)+1);
    }
  }

  public Map<String, Integer> getResult ()
  {
    return this.mufajok;
  }
  
}