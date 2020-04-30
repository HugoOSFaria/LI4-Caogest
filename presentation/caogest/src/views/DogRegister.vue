<template>
    <div id = "DogRegister">
        <v-toolbar flat color="white" height=150px>
        <v-img src="../assets/logoA5.png" max-height=150px max-width=150px></v-img>
        </v-toolbar>

  <v-row class="ma-2">
    <v-col>
      <v-card flat>
        <!-- Header -->
        <v-app-bar flat height=100px color="deep-orange lighten-4">
          <v-toolbar-title class="card-heading">Registar Cão</v-toolbar-title>
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
                                        Nome
                                    </div>
                                    
                                    </v-col>
                                    <v-col>
                                        <v-text-field 
                                            rounded 
                                            outlined 
                                            placeholder="Introduza o nome"
                                            flat 
                                            color = "grey lighten-1" 
                                            required 
                                        ></v-text-field>
                                </v-col>
                            </v-row>
                            <v-card flat height= "20" color = "white"></v-card>
                            <v-row>
                                <v-col cols="2">
                                    <div class="info-label headline">
                                        Raça
                                    </div>
                                </v-col>
                                <v-col>
                                    <v-text-field 
                                            rounded 
                                            outlined 
                                            placeholder="Introduza a raça"
                                            flat 
                                            color = "grey lighten-1" 
                                            required 
                                        ></v-text-field>
                                </v-col>
                            </v-row>
                            <v-card flat height= "20" color = "white"></v-card>
                            <v-row>
                                <v-col cols="2">
                                    <div class="info-label headline">Idade</div>
                                </v-col>
                                <v-col>
                                    <v-text-field 
                                        rounded 
                                        outlined  
                                        placeholder="Introduza a idade"
                                        flat  
                                        color = "grey lighten-1"  
                                        required 
                                ></v-text-field>
                                </v-col>
                            </v-row>
                            <v-card flat height= "20" color = "white"></v-card>
                            <v-row>
                                <v-col cols="2">
                                    <div class="info-label headline">Cor</div>
                                </v-col>
        
                                <v-col>
                                    <v-select 
                                        color = "grey"
                                        name="input-7-1"
                                        flat outlined 
                                        placeholder="Selecione a cor"
                                        :items="itemscor"
                                        multiple
                                        rounded
                                    ></v-select>
                                 </v-col>
                            </v-row>
                            <v-card flat height= "20" color = "white"></v-card>
                            <v-row>
                                <v-col cols="2">
                                    <div class="info-label headline">Porte</div>
                                </v-col>
        
                                <v-col>
                                    <v-select 
                                        color = "grey"
                                        name="input-7-1"
                                        flat outlined 
                                        placeholder="Selecione o porte"
                                        :items="itemsporte"
                                        rounded
                                    ></v-select>
                                 </v-col>
                            </v-row>
                            <v-card flat height= "20" color = "white"></v-card>
                            <v-row>
                                <v-col cols="2">
                                    <div class="info-label headline">Sexo</div>
                                </v-col>
                                <v-col>
                                    <v-radio-group row>
                                        <v-radio label="Macho" :value="true"></v-radio>
                                        <v-radio label="Fêmea" :value="false"></v-radio>
                                    </v-radio-group>
                                </v-col>
                            </v-row>
                            <v-card flat height= "20" color = "white"></v-card>
                            <v-row>
                                <v-col cols="2">
                                    <div class="info-label headline">Esterilizado</div>
                                </v-col>
                                <v-col>
                                    <v-radio-group row>
                                        <v-radio label="Sim" :value="true"></v-radio>
                                        <v-radio label="Não" :value="false"></v-radio>
                                    </v-radio-group>
                                </v-col>
                            </v-row>    
                            <v-card flat height= "20" color = "white"></v-card>
                            <v-row>
                                <v-col cols="2">
                                    <div class="info-label headline"> Notas Adicionais </div>
                                </v-col>
                                <v-col>
                                    <v-textarea
                                        flat
                                        outlined
                                        rounded
                                        auto-grow
                                        placeholder = "Introduza informações que considere relevantes"
                                        color = "grey lighten-1" 
                                        rows = "5"
                                    ></v-textarea>
                                </v-col>
                            </v-row>

                        <v-row justify = "end">
                            <v-col cols = "12" md = "8">
                                <v-row justify= "end">
                                    <v-btn class="ma-6" x-large rounded color = "deep-orange lighten-4" to = "/mainpagekennel">Cancelar</v-btn>
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
        itemsporte: [ 
            'Pequeno',
            'Médio',
            'Grande',
        ], 
        itemscor: [
            'Amarelo',
            'Azul',
            'Branco',
            'Castanho',
            'Cinzento',
            'Creme',
            'Dourado',
            'Fulvo',
            'Malhado',
            'Preto',
            'Vermelho',
        ] 
    }),  
}
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