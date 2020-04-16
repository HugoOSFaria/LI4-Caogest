<template>
    <div id = "canilRegister">
        <v-toolbar flat color="white" height=150px>
        <v-img src="../assets/logoA5.png" max-height=150px max-width=150px></v-img>
        </v-toolbar>

        <!-- Header -->
        <v-card flat>
            <v-app-bar height=100px flat color="deep-orange lighten-4">
            <v-toolbar-title class="card-heading">Formulário de Adoção</v-toolbar-title>
            </v-app-bar>
        </v-card>
        <v-card flat height= "80" color = "white"></v-card>
        <p class="text-center display-1 font-weight-black">Por favor, leia com atenção os termos de responsabilidade antes de prosseguir com a adoção.</p>
        <v-card flat height= "100" color = "white"></v-card>
        
        <v-container grid-list-md text-xl-left>
            <v-layout row wrap>
              <v-flex xs12>
                <v-card ref="form" flat >
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
                                        flat 
                                        color = "grey lighten-1" 
                                        required 
                                        placeholder="Introduza o seu nome"
                                    ></v-text-field>
                            </v-col>
                        </v-row>
                        <v-card flat height= "50" color = "white"></v-card>
                        <v-row>
                            <v-col cols="2">
                                <div class="info-label headline">
                                    Nome do Cão
                                </div>
                                
                                </v-col>
                                <v-col>
                                    <v-text-field 
                                        rounded 
                                        outlined 
                                        flat 
                                        color = "grey lighten-1" 
                                        required 
                                        placeholder="Introduza o nome do cão a adotar"
                                    ></v-text-field>
                            </v-col>
                        </v-row>
                        <v-card flat height= "50" color = "white"></v-card>
                        <v-row>
                            <v-col cols="2">
                                <div class="info-label headline">
                                    Tipo de Residência
                                </div>
                                
                                </v-col>
                                <v-col>
                                    <v-text-field 
                                        rounded 
                                        outlined 
                                        flat 
                                        color = "grey lighten-1" 
                                        required 
                                        placeholder="Introduza o tipo de residência"
                                    ></v-text-field>
                            </v-col>
                        </v-row>
                        <v-card flat height= "50" color = "white"></v-card>
                        <v-row>
                            <v-col cols="2">
                                <div class="info-label headline">
                                    Número de Cartão de Cidadão
                                </div>
                                
                                </v-col>
                                <v-col>
                                    <v-text-field 
                                        rounded 
                                        outlined 
                                        flat 
                                        color = "grey lighten-1" 
                                        required 
                                        placeholder="Introduza o seu número de cartão de cidadão"
                                    ></v-text-field>
                            </v-col>
                        </v-row>
                        <v-card flat height= "50" color = "white"></v-card>
                        <v-row>
                            <v-col cols="2">
                                <div class="info-label headline">
                                    Comprovativo de morada
                                </div>
                                
                                </v-col>
                                <v-col>
                                    <v-file-input 
                                        rounded 
                                        outlined 
                                        prepend-icon=""
                                        flat
                                        placeholder="Adicione um comprovativo de morada"
                                        prepend-inner-icon = "search">
                                    </v-file-input>
                            </v-col>
                        </v-row>
                        <v-card flat height= "50" color = "white"></v-card>
                        <v-row>
                            <v-col cols="12">
                                <v-checkbox
                                color="deep-orange lighten-4"
                                >
                                <template v-slot:label>
                                    <div>
                                    Aceita os 
                                    <a>termos</a>
                                    e
                                    <a>condições</a>
                                    de responsabilidade?
                                    </div>
                                </template>
                                </v-checkbox>
                            </v-col>
                        </v-row>
                    </v-card-text>

                    <v-card-actions>
                        <v-spacer></v-spacer>
                        <v-btn class="ma-6" x-large rounded color = "deep-orange lighten-4" to="/dogs">Cancelar</v-btn>
                        <v-btn
                            :disabled="true"
                            class="ma-6"
                            x-large
                            rounded
                            color="deep-orange lighten-4"
                            type="submit"
                        >Registar</v-btn>
                    </v-card-actions>
                    </v-card>
                </v-flex>
            </v-layout>  
        </v-container>
    <appFooter app></appFooter>
    </div>
</template>

<script>
import Footer from '../components/Footer.vue'
export default {
    components: { 'appFooter': Footer }
}
</script>

<style scoped>
.parallax {
  min-height: 100vh;
  align-items: center;
}

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