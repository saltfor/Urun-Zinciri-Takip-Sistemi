package com.example.pcts;

import android.content.Intent;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;
import android.widget.Toast;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

public class UrunActivity extends AppCompatActivity {

    TextView txturunkodu;
    String urunkodu;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_urun);

        Intent intent=getIntent();
        txturunkodu=findViewById(R.id.txtshowurunkodu);
        urunkodu=intent.getStringExtra("no");
        txturunkodu.setText("Ürün Kodu : "+urunkodu);
        new arkaPlan().execute("http://192.168.56.1:8000/listele");
    }

    class arkaPlan extends AsyncTask<String,String,String> {
        protected String doInBackground(String ... params){
            HttpURLConnection con=null;
            BufferedReader br=null;
            try {
                URL url=new URL(params[0]);
                con=(HttpURLConnection)url.openConnection();
                con.connect();
                InputStream is=con.getInputStream();
                br=new BufferedReader(new InputStreamReader(is));
                String satir;
                String dosya="";
                while((satir=br.readLine())!=null){
                    dosya+=satir;
                }
                return dosya;
            }catch (Exception e){
                e.printStackTrace();
                return "bir hata olustu";
            }
        }
        protected void onPostExecute(String s){
            int bayrak=0;
            int kod=Integer.parseInt(urunkodu);
            try {
                JSONArray jo=new JSONArray(s);
                for (int i=0;i<jo.length();i++){
                    if(jo.getJSONObject(i).getInt("urunkodu") == kod){
                        bayrak=1;
                        ((TextView)findViewById(R.id.txtcayturu)).setText(jo.getJSONObject(i).getString("cayturu"));
                        ((TextView)findViewById(R.id.txttoplayan)).setText(jo.getJSONObject(i).getString("toplayan"));
                        ((TextView)findViewById(R.id.txtttarihi)).setText(jo.getJSONObject(i).getString("ttarihi"));
                        ((TextView)findViewById(R.id.txtdeniz)).setText(jo.getJSONObject(i).getString("deniz"));
                        ((TextView)findViewById(R.id.txtyagis)).setText(jo.getJSONObject(i).getString("yagis"));
                        ((TextView)findViewById(R.id.txtnem)).setText(jo.getJSONObject(i).getString("nem"));
                        ((TextView)findViewById(R.id.txtsicaklik)).setText(jo.getJSONObject(i).getString("sicaklik"));
                        ((TextView)findViewById(R.id.txtetarih)).setText(jo.getJSONObject(i).getString("etarih"));
                        ((TextView)findViewById(R.id.txteso)).setText(jo.getJSONObject(i).getString("eso"));
                        ((TextView)findViewById(R.id.txtmuhafaza)).setText(jo.getJSONObject(i).getString("muhafaza"));
                        ((TextView)findViewById(R.id.txtftarih)).setText(jo.getJSONObject(i).getString("ftarih"));
                        ((TextView)findViewById(R.id.txtbozuk)).setText(jo.getJSONObject(i).getString("bozuk"));
                        ((TextView)findViewById(R.id.txtsso)).setText(jo.getJSONObject(i).getString("sso"));
                        ((TextView)findViewById(R.id.txtbuharlasma)).setText(jo.getJSONObject(i).getString("buharlasma"));
                        ((TextView)findViewById(R.id.txtkso)).setText(jo.getJSONObject(i).getString("kso"));
                        ((TextView)findViewById(R.id.txtksure)).setText(jo.getJSONObject(i).getString("ksure"));
                        ((TextView)findViewById(R.id.txtfso)).setText(jo.getJSONObject(i).getString("fso"));
                        ((TextView)findViewById(R.id.txtfhava)).setText(jo.getJSONObject(i).getString("fhava"));
                        ((TextView)findViewById(R.id.txtrutubet)).setText(jo.getJSONObject(i).getString("rutubet"));
                        ((TextView)findViewById(R.id.txtkuso)).setText(jo.getJSONObject(i).getString("kuso"));
                        ((TextView)findViewById(R.id.txtkuhava)).setText(jo.getJSONObject(i).getString("kuhava"));
                        ((TextView)findViewById(R.id.txtfirin)).setText(jo.getJSONObject(i).getString("firin"));
                        ((TextView)findViewById(R.id.txtfirinnem)).setText(jo.getJSONObject(i).getString("firinnem"));
                        ((TextView)findViewById(R.id.txttso)).setText(jo.getJSONObject(i).getString("tso"));
                        ((TextView)findViewById(R.id.txtnevi)).setText(jo.getJSONObject(i).getString("nevi"));
                        ((TextView)findViewById(R.id.txthso)).setText(jo.getJSONObject(i).getString("hso"));
                        ((TextView)findViewById(R.id.txtvolume)).setText(jo.getJSONObject(i).getString("volume"));
                        ((TextView)findViewById(R.id.txtlso)).setText(jo.getJSONObject(i).getString("lso"));
                        ((TextView)findViewById(R.id.txtrenk)).setText(jo.getJSONObject(i).getString("renk"));
                        ((TextView)findViewById(R.id.txtkoku)).setText(jo.getJSONObject(i).getString("koku"));
                        ((TextView)findViewById(R.id.txtaroma)).setText(jo.getJSONObject(i).getString("aroma"));
                        ((TextView)findViewById(R.id.txtonay)).setText(jo.getJSONObject(i).getString("onay"));
                        ((TextView)findViewById(R.id.txtgram)).setText(jo.getJSONObject(i).getString("gram"));
                        ((TextView)findViewById(R.id.txtcikistarih)).setText(jo.getJSONObject(i).getString("cikistarihi"));
                        ((TextView)findViewById(R.id.txtraftarih)).setText(jo.getJSONObject(i).getString("raftarihi"));
                    }
                }
                if(bayrak==0){
                    Toast.makeText(getApplicationContext(), "URUN BULUNAMADI", Toast.LENGTH_LONG).show();
                    finish();
                }
            }
            catch (Exception e){
                Toast.makeText(getApplicationContext(), "HATA VAR", Toast.LENGTH_LONG).show();
                finish();
                e.printStackTrace();
            }

        }
    }
}
