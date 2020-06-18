package com.example.pcts;

import android.content.Intent;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;




public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Button btn=findViewById(R.id.button);

        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                TextView txturunkodu=findViewById(R.id.txturunkodu);
                Intent i = new Intent(MainActivity.this, UrunActivity.class);
                i.putExtra("no",txturunkodu.getText().toString());
                startActivity(i);
            }
        });
    }

}
