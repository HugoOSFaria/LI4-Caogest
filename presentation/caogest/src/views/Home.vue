<template>
  <div id = "login" >
    
        <v-card class = "ma-8" flat color = "transparent">
          <v-btn dark text class = "headline ma-2 text-lowercase">Sobre</v-btn>
          <v-btn dark text class = "headline text-lowercase" @click="openContactos">Contactos</v-btn>
        </v-card>

      <v-col cols = "12">
      <v-card height = "250"  color = "transparent" flat></v-card>
      <v-row align = "center" justify = "center">
          <v-card color = "transparent" flat width = "600">
            <v-card-text class="justify-center">
               <v-form ref="form" lazy-validation>
                <v-text-field 
                  class = "headline"
                  dark 
                  color="white" 
                  rounded 
                  label="Email" 
                  type="email"
                  name="email"
                  v-model="form.email"
                  prepend-icon="email"
                  :rules="regraEmail"
                  outlined
                  required 
                />
                <v-text-field
                  class = "headline"
                  dark 
                  color="white" 
                  rounded 
                  prepend-icon="lock"
                  outlined   
                  v-model="form.password"
                  :rules="regraPassword"
                  name="password"
                  label="Password"
                  type="password"
                  required
                />
              </v-form>
              <v-btn depressed class="ma-2 headline" dark color = "transparent" type="submit" @click="loginUtilizador"> Entrar </v-btn>
              
              <v-dialog v-model="dialog" persistent max-width="350">
                <template v-slot:activator="{ on }">
                  <v-btn depressed class="ma-2 headline" v-on="on" dark color = "transparent"> Registar </v-btn>
                </template>

                <v-row align = "center" justify = "center">
                  <v-card flat color = "transparent">
                    <v-card-text>
                      <div>
                        <v-btn x-large depressed class="ma-4 headline" dark color = "transparent" to = "/registar/utilizador">Registar Utilizador</v-btn>
                      </div>

                      <div>
                        <v-btn x-large depressed class="ma-4 headline" dark color = "transparent" to = "/registar/canil">Registar Canil</v-btn>
                      </div>

                      <div>
                        <v-btn x-large depressed class="ma-4 headline" dark color = "transparent" @click="dialog = false">Cancelar</v-btn>
                      </div>
                    </v-card-text>
                  </v-card>
                </v-row>
              </v-dialog>

            </v-card-text>
            <v-snackbar
            v-model="snackbar"
            :timeout="timeout"
            :color="color"
            :top="true"
          >
            {{ text }}
          </v-snackbar>
          </v-card>
        </v-row>

        <v-card flat color = "transparent" height = "200"></v-card>

        <v-row>
          <v-card flat color = "transparent" class = "mx-auto">
            <v-img 
              src="../assets/logoA3.png"
              max-width="600"
            ></v-img>
          </v-card>
      </v-row>
    </v-col>
    </div>
</template>


<script>

const lhost = require("@/config/global").host;
import axios from "axios";

export default {
  name: "login",
  data (){
    return {
      form:{
        email: "",
        password: "",
      },
      regraEmail: [ v => !!v || "Email obrigatório."],
      regraPassword: [v => !!v || "Palavra-passe obrigatória."],
      dialog: false,
      snackbar: false,
      color: "",
      timeout: 4000,
      text: "",
      done: false
    }
  }, 
  methods: {
    openContactos: function(){
      this.$router.push("/caogest/sobre");
    },
    async loginUtilizador() {
      if (this.$refs.form.validate()) {
        try{
          var res = await axios.post(lhost + "/api/Login", {
            email: this.$data.form.email,
            password: this.$data.form.password 
          })
            if (res.data.token != undefined && res.data.nome != undefined){
              this.$store.commit("guardaTokenUtilizador", res.data.token); 
              this.$store.commit("guardaNomeUtilizador", res.data.nome); 
              this.$store.commit("guardaTipoUtilizador", res.data.tipo); 
              if(res.data.tipo == 0)
                this.$router.push("/pagina/admin/" + this.$data.form.email);
              if(res.data.tipo == 1)
                this.$router.push("/pagina/utilizador/" + this.$data.form.email);
              if(res.data.tipo == 2)
                this.$router.push("/pagina/canil/" + this.$data.form.email);
            }
            else{
              this.text = "Email ou Palavra-Passe incorretos!"; 
              this.color = "error"; 
              this.snackbar = true; 
              this.done = false; 
            }
          }
          catch(e) {
            this.text = "Email ou Palavra-Passe incorretos!";
            this.color = "error";
            this.snackbar = true;
            this.done = false;
            console.log(JSON.stringify(e));
          }
        } else {
          this.text = "Por favor preencha todos os campos!";
          this.color = "error";
          this.snackbar = true;
          this.done = false;
        }
      }
    }
  }
</script>

<style scoped>
#login{
    width: 100%;
    height: 100%;
    position: absolute;
    top: 0;
    left: 0;
    background-image: url('../assets/image-2.jpg');
    background-size: cover;
  }

</style>
