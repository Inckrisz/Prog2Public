import java.util.ArrayList;
import java.util.List;

public class BookUtils {
  private BookUtils()
  {

  }

  public static List<String> explode (String line)
  {
    List<String> lista = new ArrayList<>();

    String[] ertekek = line.split(",");
    for (String s : ertekek)
    {
      String newString = clean(s);
      lista.add(newString);
    }

    return lista;
  }

  public static String clean (String s)
  {
    return s.trim();
  }
}
