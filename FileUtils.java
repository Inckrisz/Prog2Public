import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class FileUtils {

  public static List<String> readLines (String fname)
  {
    List<String> lista = new ArrayList<>();

    try
    {
      String line;
      BufferedReader br = new BufferedReader(new FileReader(fname));
      while ((line = br.readLine()) != null)
      {
        lista.add(line);
      }
      br.close();
    }
    catch (IOException e)
    {
      e.printStackTrace();
    }

    return lista;
}

  
}
