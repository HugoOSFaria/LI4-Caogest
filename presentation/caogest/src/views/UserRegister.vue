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
                        <v-card ref="form" flat>
                            <v-card-text>
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
                                        v-model="password"
                                            :type="show1 ? 'text' : 'password'"
                                            name="input-10-1" 
                                        ></v-text-field>
                                    </v-col>
                                </v-row>

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
                                    ></v-text-field>
                                    </v-col>
                                </v-row>
        
                                <v-row>
                                    <v-col cols="2">
                                    <div class="info-label headline">Data de Nascimento</div>
                                    </v-col>
                                    <v-col>
                                    <v-menu
                                        ref="open"
                                        v-model="open"
                                        :close-on-content-click="false"
                                        :nudge-right="40"
                                        transition="scale-transition"
                                        offset-y
                                        max-width="290px"
                                        min-width="290px"
                                    >
                                        <template v-slot:activator="{ on }">
                                        <v-text-field
                                            placeholder="Selecione a sua data de nascimento"
                                            rounded
                                            outlined
                                            flat
                                            solo
                                            color = "grey lighten-1"  
                                            v-model="computedDateFormatted"
                                            persistent-hint
                                            readonly
                                            @blur="date = parseDate(dateFormatted)"
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
                                        <v-radio-group row>
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
                                        name="input-7-1"
                                        flat outlined 
                                        placeholder="Selecione o distrito onde reside"
                                        :items="distritos"
                                        rounded
                                    ></v-select>
                                 </v-col>
                                </v-row>
                             
                                <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline">Código Postal</div>
                                    </v-col>
                                    <v-col cols="2" sm="6">
                                        <v-text-field
                                        rounded 
                                        outlined 
                                        flat 
                                        persistent-hint
                                        color="grey lighten-1"
                                        required
                                        placeholder="0000-000"
                                        ></v-text-field>
                                    </v-col>
                                </v-row>
                                
                                <v-row>
                                <v-col cols="2">
                                <div class="info-label headline">Número Contribuinte</div>
                                </v-col>
                                <v-col>
                                <v-text-field 
                                        rounded 
                                        outlined 
                                        flat 
                                        color = "grey lighten-1"  
                                        required 
                                        placeholder="Introduza o seu número de contribuinte"
                                    ></v-text-field>
                                </v-col>
                            </v-row>
                                <v-card flat height= "20" color = "white"></v-card>
                            <v-row justify = "end">
                                <v-col cols = "12" md = "8">
                                    <v-row justify= "end">
                                        <v-btn class="ma-6" x-large rounded color = "deep-orange lighten-4" to = "/">Cancelar</v-btn>
                                        <v-btn class = "ma-6" x-large rounded color = "deep-orange lighten-4">Registar</v-btn>
                                    </v-row>
                                </v-col>
                            </v-row>

                        </v-card-text>
                    </v-card>
                </v-flex>
            </v-layout>
        </v-container>    
      </v-card>
    </v-col>
  </v-row>
  </div>
</template>

<script>

export default {
  data: () => ({
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
        ] 
    
  }),
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