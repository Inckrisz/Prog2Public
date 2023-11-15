import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;

public class Main {
  public static void main(String[] args) {
    String fname = "books.csv";
    List<String> books = FileUtils.readLines(fname);
    books.remove(0);
    
    List<String> mufajok = new ArrayList<>();

    for (String s : books)
    {
      String[] ertekek = s.split(";");
      List<String> genre = BookUtils.explode(ertekek[5]);
      mufajok.addAll(genre);
    }

    Genre g = new Genre();
    g.register(mufajok);
    Map<String, Integer> genres = g.getResult();

    for (Entry e : genres.entrySet())
    {
      System.out.println(e.getKey() + ": " + e.getValue());
    }



    // System.out.println(mufajok);

  }
}
