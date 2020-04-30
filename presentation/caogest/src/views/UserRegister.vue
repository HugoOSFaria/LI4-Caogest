<template>
    <div id = "userRegister">
        <v-toolbar flat color="white" height=150px>
        <v-img src="../assets/logoA5.png" max-height=150px max-width=150px></v-img>
        </v-toolbar>

  <v-row class="ma-2">
    <v-col>
      <v-card flat>
        <!-- Header -->
        <v-app-bar flat height=100px color="deep-orange lighten-4">
          <v-toolbar-title class="card-heading">Registar Utilizador</v-toolbar-title>
        </v-app-bar>
        <v-card flat height= "80" color = "white"></v-card>
        <!-- Content -->
            <v-container grid-list-md text-xl-left>
                <v-layout row wrap>
                <v-flex xs12>
                    <v-form ref="form" lazy-validation>
                        <v-card  flat>
                            <v-card-text>
                                <v-row>
                                    <v-col cols="2">
                                    <div class="info-label headline">Nome</div>
                                    </v-col>
                                    <v-col>
                                    <v-text-field 
                                        rounded 
                                        outlined  
                                        flat  
                                        color = "grey lighten-1"  
                                        required 
                                        placeholder="Introduza o seu nome"
                                        v-model="form.nome"
                                        :rules="regraNome"
                                        name="nome"
                                        type="nome"
                                    ></v-text-field>
                                    </v-col>
                                </v-row>

                                <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline">
                                            E-mail
                                        </div>
                                        
                                        </v-col>
                                        <v-col>
                                        <v-text-field 
                                            rounded 
                                            outlined 
                                            flat 
                                            color = "grey lighten-1" 
                                            required 
                                            placeholder="Introduza o seu e-mail"
                                            v-model="form.email"
                                            :rules="regraEmail"
                                            name="email"
                                            type="email"
                                        ></v-text-field>
                                    </v-col>
                                </v-row>

                                <v-row>
                                    <v-col cols="2">
                                    <div class="info-label headline">
                                        Palavra-passe
                                    </div>
                                    </v-col>
                                    <v-col>
                                    <v-text-field 
                                        rounded 
                                        outlined 
                                        flat  
                                        required
                                        placeholder="Introduza uma palavra-passe"
                                        color = "grey lighten-1" 
                                        v-model="form.password"
                                        :rules="regraPassword"
                                        :type="show1 ? 'text' : 'password'"
                                        name="password" 
                                        ></v-text-field>
                                    </v-col>
                                </v-row>
        
                                <v-row>
                                    <v-col cols="2">
                                    <div class="info-label headline">Data de Nascimento</div>
                                    </v-col>
                         
                                    <v-col>
                                    <v-menu
                                        v-model="menu2"
                                        :close-on-content-click="false"
                                        transition="scale-transition"
                                        offset-y
                                        max-width="290px"
                                        min-width="290px"
                                    >
                                        <template v-slot:activator="{ on }">
                                        <v-text-field
                                            outlined 
                                            rounded
                                            placeholder="YYYY/MM/DD"
                                            flat
                                            color = "grey lighten-1" 
                                            v-model="date"
                                            persistent-hint
                                            readonly
                                            v-on="on"
                                        ></v-text-field>
                                        </template>
                                        <v-date-picker v-model="date" no-title @input="menu2 = false"></v-date-picker>
                                    </v-menu>
                                    </v-col>
 
                                </v-row>

                                <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline">Sexo</div>
                                    </v-col>
                                    <v-col>
                                        <v-radio-group row v-model="form.sexo" name="sexo" type="sexo">
                                            <v-radio label="Masculino" :value="true"></v-radio>
                                            <v-radio label="Feminino" :value="false"></v-radio>
                                        </v-radio-group>
                                    </v-col>
                                </v-row>
                                
                                <v-row>
                                    <v-col cols="2">
                                    <div class="info-label headline">Morada</div>
                                    </v-col>
                                    <v-col>
                                    <v-text-field 
                                            rounded 
                                            outlined 
                                            flat 
                                            color = "grey lighten-1"  
                                            required 
                                            placeholder="Introduza a sua morada"
                                            v-model="form.rua"
                                            :rules="regraRua"
                                            name="rua"
                                            type="rua"
                                        ></v-text-field>
                                    </v-col>
                                </v-row>
                               
                                <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline">Concelho</div>
                                        </v-col>
                                        <v-col>
                                        <v-text-field 
                                            rounded 
                                            outlined 
                                            flat 
                                            color = "grey lighten-1"  
                                            required 
                                            placeholder="Introduza o concelho onde reside"
                                            v-model="form.localidade"
                                            :rules="regraLocalidade"
                                            name="localidade"
                                            type="localidade"
                                        ></v-text-field>
                                    </v-col>
                                </v-row>

                                 <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline">Distrito</div>
                                    </v-col>
                                    <v-col>
                                    <v-select 
                                        color = "grey"
                                        flat outlined 
                                        placeholder="Selecione o distrito onde reside"
                                        :items="distritos"
                                        rounded
                                        v-model="form.distrito"
                                        :rules="regraDistrito"
                                        name="distrito"
                                        type="distrito"
                                    ></v-select>
                                 </v-col>
                                </v-row>
                                
                                <v-row>
                                <v-col cols="2">
                                <div class="info-label headline">Número Cartão de Cidadão</div>
                                </v-col>
                                <v-col>
                                <v-text-field 
                                        rounded 
                                        outlined 
                                        flat 
                                        color = "grey lighten-1"  
                                        required 
                                        placeholder="Introduza o seu número de cartão de cidadão"
                                        v-model="form.cc"
                                        :rules="regraCC"
                                        name="cc"
                                        type="cc"
                                    ></v-text-field>
                                </v-col>
                            </v-row>
                                <v-card flat height= "20" color = "white"></v-card>
                            <v-row justify = "end">
                                <v-col cols = "12" md = "8">
                                    <v-row justify= "end">
                                        <v-btn class="ma-6" type="submit" x-large rounded color = "deep-orange lighten-4" @click="cancelar">Cancelar</v-btn>
                                        <v-btn class = "ma-6" type="submit" x-large rounded color = "deep-orange lighten-4" @click="registarUtilizador">Registar</v-btn>
                                    </v-row>
                                </v-col>
                            </v-row>
                            </v-card-text>
                            <v-snackbar
                                v-model="snackbar"
                                :color="color"
                                :timeout="timeout"
                                :bottom="true"
                                multi-line
                            >
                                {{ text }}
                                <v-btn flat @click="fecharSnackbar">Fechar</v-btn>
                            </v-snackbar>
                        </v-card>
                                </v-form>
                    </v-flex>
                </v-layout>
            </v-container>    
        </v-card>
    </v-col>
  </v-row>
  <p> {{JSON.stringify(this.form)}}</p>
  </div>
</template>

<script>
import axios from 'axios'
const lhost = require("@/config/global").host;

export default {
    name: "signup",
    data: () => ({
        date: new Date().toISOString().substr(0, 10),
        menu2: false,
        show1: false, 
        password: 'Password',
        distritos: [
            'Angra do Heroísmo',
            'Aveiro',
            'Beja',
            'Braga',
            'Bragança',
            'Castelo Branco',
            'Coimbra',
            'Évora',
            'Faro',
            'Funchal',
            'Guarda',
            'Horta',
            'Leiria',
            'Lisboa',
            'Ponta Delgada',
            'Portalegre',
            'Porto',
            'Santarém',
            'Setúbal',
            'Viana do Castelo',
            'Viseu',
        ], 
        regraNome: [v => !!v || "Nome obrigatório."],
        regraEmail:[v => !!v || "Email obrigatório."], 
        regraPassword: [v => !!v || "Palavra-passe obrigatória."],
        regraRua: [v => !!v || "Morada obrigatória."],
        regraDistrito: [v => !!v || "Distrito obrigatório."],
        regraCC: [v => !!v || "Número de Cartão de Cidadão obrigatório."],
        regraLocalidade: [v => !!v || "Concelho obrigatório."],
        regraData: [v => !!v || "Data de Nascimento obrigatória."],
        form: {
            nome: "",
            email: "", 
            password: "", 
            rua: "", 
            localidade: "", 
            cc: "", 
            distrito: "", 
            data_de_nascimento:"1999-04-13T00:00:00", 
            sexo:"",
        }, 
        snackbar: false, 
        color: "", 
        done: false, 
        timeout: 4000,
        text: "", 
    }),
  methods: {
    registarUtilizador() {
      if (this.$refs.form.validate()) {
        alert(JSON.stringify(this.form));
        axios
          .post(lhost + "/api/Utilizadors", {
            nome: this.form.nome,
            email: this.form.email,
            rua: this.form.rua,
            localidade: this.form.localidade,
            distrito: this.form.distrito,
            data_de_nascimento: this.form.data_de_nascimento,
            sexo: this.form.sexo,
            cc: this.form.cc,
            password: this.form.password,
          })
          .then( resposta =>
            alert("sucess" + resposta)
          )
          .catch(function(err) {
            alert(err);
            
          });
      } else {
        alert("erro!!");
        this.text = "Por favor preencha todos os campos!";
        this.color = "error";
        this.snackbar = true;
        this.done = false;
      }
    },
    fecharSnackbar() {
      this.snackbar = false;
      if (this.done == true) this.$router.push("/");
    },
    cancelar() {
      this.$router.push("/");
    }
  }
};
</script>

<style scoped>
.card-heading {
  font-size: x-large;
  font-weight: bold;
}
.info-label {
  color: "grey lighten-1"; 
  padding: 2px;
  font-weight: 500;
  width: 100%;
  background-color: "transparent";
  font-weight: bold;
  margin: 20px;
  border-radius: 50x;
}
</style>