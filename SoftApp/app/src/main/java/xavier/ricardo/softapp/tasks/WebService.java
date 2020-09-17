package xavier.ricardo.softapp.tasks;

import android.util.Log;

import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.params.BasicHttpParams;
import org.apache.http.params.HttpConnectionParams;
import org.apache.http.params.HttpParams;

import java.io.IOException;

public class WebService {

    private static String servidor;
    private static String servico;

    public static String getServidor() {
        return servidor;
    }

    public static void setServidor(String servidor) {
        servico = servidor.equals("ricardoxavier.no-ip.org") ? "soft-ws3" : "softws";
        WebService.servidor = servidor;
    }

    public static String getServico() {
        return servico;
    }

    public static void defineServidor() {

        servidor = "softplacemoveis.dyndns.org:8080";
        servico = "softws";

        try {
            String url = String.format("http://%s/%s/softws", servidor, servico);
            HttpParams httpParameters = new BasicHttpParams();
            HttpConnectionParams.setConnectionTimeout(httpParameters, 5000);
            HttpClient httpClient = new DefaultHttpClient(httpParameters);
            HttpGet httpGet = new HttpGet(url);
            HttpResponse httpResponse = httpClient.execute(httpGet);
            int status = httpResponse.getStatusLine().getStatusCode();
            Log.i("SOFTAPP", String.valueOf(status));

        } catch (IOException e) {
            servidor = "ricardoxavier.no-ip.org";
            servico = "soft-ws3";
        }
    }
}
