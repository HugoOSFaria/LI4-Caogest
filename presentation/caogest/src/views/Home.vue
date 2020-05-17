<template>
  <div id = "login" >
    <v-col cols = "12">
      <v-card height = "300"  color = "transparent" flat></v-card>
      
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
              <v-btn depressed class="ma-2 headline" dark color = "transparent" to="/pagina/utilizador"> Entrar </v-btn>
              
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
// @ is an alias to /src
//const lhost = require("@/config/global").host;
//import axios from "axios";

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
      dialog: false
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
