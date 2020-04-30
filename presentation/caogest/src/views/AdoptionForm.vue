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
        <v-card flat height= "150" color = "white"></v-card>
        <v-card class = "mx-auto" max-width = "1500" flat>
            <p class="text-center display-1 font-weight-black">Por favor, leia com atenção os termos de responsabilidade antes de prosseguir com o pedido adoção. Após submetido, o pedido será avaliado pelo canil onde se encontra acolhido o cão. O estado do pedido poderá ser visualizado nos seus pedidos de adoção. </p>
        </v-card>
        <v-card flat height= "100" color = "white"></v-card>

        <div> 

            <v-card color = "grey lighten-2" class = "mx-auto" max-width = "1500" fluid outlined rounded>
                <v-row>
                    <v-col>
                        <v-card flat height= "30" color = "grey lighten-2"></v-card>  
                        <span class = " pa-8 headline font-weight-regular" color = "grey"> Nome Completo * </span> 
                    </v-col>
                </v-row>
                <v-row>
                    <v-col cols = "6">
                        <v-text-field
                            ref="name"
                            v-model="name"
                            required
                            color = "deep-orange darken-4"
                            class = "pa-8"
                            placeholder="Introduza o seu nome"
                        ></v-text-field>
                    </v-col>
                </v-row>
            </v-card>
                
            <v-card flat height= "80" color = "white"></v-card>   

            <v-card class = "mx-auto" max-width = "1500" color = "grey lighten-2" fluid outlined rounded>
                <v-row>
                    <v-col>
                        <v-card flat height= "30" color = "grey lighten-2"></v-card>  
                        <span class = " pa-8 headline font-weight-regular" color = "grey"> Nome do Cão * </span> 
                    </v-col>
                </v-row>
                <v-row>
                    <v-col cols = "6">
                        <v-text-field
                            ref="name"
                            v-model="name"
                            required
                            color = "deep-orange darken-4"
                            class = "pa-8"
                            placeholder="Introduza o nome do cão que pretende adotar"
                        ></v-text-field>
                    </v-col>
                </v-row>
            </v-card>    

            <v-card flat height= "80" color = "white"></v-card>   

            <v-card class = "mx-auto" max-width = "1500" color = "grey lighten-2" fluid outlined rounded>
                <v-row>
                    <v-col>
                        <v-card flat height= "30" color = "grey lighten-2"></v-card>  
                        <span class = " pa-8 headline font-weight-regular" color = "grey"> Tipo de Moradia * </span> 
                    </v-col>
                </v-row>
                <v-row>
                    <v-container fluid>
                         <v-radio-group column v-model="radios" :mandatory="false" class = "ma-12" >
                            <v-radio color = "deep-orange darken-4" label="Apartamento" value="apartamento"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Vivenda" value="vivenda"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Moradia" value="moradia"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Terreno" value="terreno"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Empresa/Fábrica" value="empresa/fábrica"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Outra" value="outra"></v-radio>
                        </v-radio-group>
                    </v-container>
                </v-row>
            </v-card>    

            <v-card flat height= "80" color = "white"></v-card>   

            <v-card class = "mx-auto" max-width = "1500" color = "grey lighten-2" fluid outlined rounded>
                <v-row>
                    <v-col>
                        <v-card flat height= "30" color = "grey lighten-2"></v-card>  
                        <span class = " pa-8 headline font-weight-regular" color = "grey"> Espaço exterior ou equivalente * </span> 
                    </v-col>
                </v-row>
                <v-row>
                    <v-container fluid>
                         <v-radio-group column v-model="radios" :mandatory="false" class = "ma-12" >
                            <v-radio color = "deep-orange darken-4" label="Varanda" value="varanda"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Terraço" value="terraço"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Marquise" value="marquise"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Jardim" value="jardim"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Nenhum" value="nenhum"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Outra" value="outra"></v-radio>
                        </v-radio-group>
                    </v-container>
                </v-row>
            </v-card>      

            <v-card flat height= "80" color = "white"></v-card>   

            <v-card class = "mx-auto" max-width = "1500" color = "grey lighten-2" fluid outlined rounded>
                <v-row>
                    <v-col>
                        <v-card flat height= "30" color = "grey lighten-2"></v-card>  
                        <span class = " pa-8 headline font-weight-regular" color = "grey"> A sua habitação é.. * </span> 
                    </v-col>
                </v-row>
                <v-row>
                    <v-container fluid>
                         <v-radio-group column v-model="radios" :mandatory="false" class = "ma-12" >
                            <v-radio color = "deep-orange darken-4" label="Própria" value="própria"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Alugada" value="alugada"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Condomínio" value="condomínio"></v-radio>
                        </v-radio-group>
                    </v-container>
                </v-row>
            </v-card>      

            <v-card flat height= "80" color = "white"></v-card>   

            <v-card class = "mx-auto" max-width = "1500" color = "grey lighten-2" fluid outlined rounded>
                <v-row>
                    <v-col>
                        <v-card flat height= "30" color = "grey lighten-2"></v-card>  
                        <span class = " pa-8 headline font-weight-regular" color = "grey"> Caso seja alugada ou condomínio, tem permissão para ter animais? * </span> 
                    </v-col>
                </v-row>
                <v-row>
                    <v-container fluid>
                         <v-radio-group column v-model="radios" :mandatory="false" class = "ma-12" >
                            <v-radio color = "deep-orange darken-4" label="Sim" value="sim"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Não" value="não"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="É própria" value="própria"></v-radio>
                        </v-radio-group>
                    </v-container>
                </v-row>
            </v-card>      

            <v-card flat height= "80" color = "white"></v-card>   

            <v-card class = "mx-auto" max-width = "1500" color = "grey lighten-2" fluid outlined rounded>
                <v-row>
                    <v-col>
                        <v-card flat height= "30" color = "grey lighten-2"></v-card>  
                        <span class = " pa-8 headline font-weight-regular" color = "grey"> Pretende um cão para... </span> 
                    </v-col>
                </v-row>
                <v-row>
                    <v-container fluid>
                         <v-radio-group column v-model="radios" :mandatory="false" class = "ma-12" >
                            <v-radio color = "deep-orange darken-4" label="Companhia" value="companhia"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Caça" value="caça"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Guarda" value="guarda"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Dar de presente" value="presente"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Outra" value="outra"></v-radio>
                        </v-radio-group>
                    </v-container>
                </v-row>
            </v-card>      

            <v-card flat height= "80" color = "white"></v-card>   

            <v-card class = "mx-auto" max-width = "1500" color = "grey lighten-2" fluid outlined rounded>
                <v-row>
                    <v-col>
                        <v-card flat height= "30" color = "grey lighten-2"></v-card>  
                        <span class = " pa-8 headline font-weight-regular" color = "grey"> Em caso de ausência para férias, trabalho ou outra, o seu cão: </span> 
                    </v-col>
                </v-row>
                <v-row>
                    <v-container fluid>
                         <v-radio-group column v-model="radios" :mandatory="false" class = "ma-12" >
                            <v-radio color = "deep-orange darken-4" label="Acompanhará a família" ></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Ficará com familiares/amigos"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Ficará num hotel"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Ficará sozinho em casa" ></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Outro" ></v-radio>
                        </v-radio-group>
                    </v-container>
                </v-row>
            </v-card>      

            <v-card flat height= "80" color = "white"></v-card>   

            <v-card class = "mx-auto" max-width = "1500" color = "grey lighten-2" fluid outlined rounded>
                <v-row>
                    <v-col>
                        <v-card flat height= "30" color = "grey lighten-2"></v-card>  
                        <span class = " pa-8 headline font-weight-regular" color = "grey"> Tem alguém alérgico a cães na família? * </span> 
                    </v-col>
                </v-row>
                <v-row>
                    <v-container fluid>
                         <v-radio-group column v-model="radios" :mandatory="false" class = "ma-12" >
                            <v-radio color = "deep-orange darken-4" label="Sim" value="sim"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Não" value="não"></v-radio>
                        </v-radio-group>
                    </v-container>
                </v-row>
            </v-card>      

            <v-card flat height= "80" color = "white"></v-card>   

            <v-card class = "mx-auto" max-width = "1500" color = "grey lighten-2" fluid outlined rounded>
                <v-row>
                    <v-col>
                        <v-card flat height= "30" color = "grey lighten-2"></v-card>  
                        <span class = " pa-8 headline font-weight-regular" color = "grey"> É dono de mais algum animal? * </span> 
                    </v-col>
                </v-row>
                <v-row>
                    <v-container fluid>
                         <v-radio-group column v-model="radios" :mandatory="false" class = "ma-12" >
                            <v-radio color = "deep-orange darken-4" label="Sim" value="sim"></v-radio>
                            <v-radio color = "deep-orange darken-4" label="Não" value="não"></v-radio>
                        </v-radio-group>
                    </v-container>
                </v-row>
            </v-card>      

            <v-card flat height= "80" color = "white"></v-card>   

            <v-card class = "mx-auto" max-width = "1500" color = "grey lighten-2" fluid outlined rounded>
                <v-row>
                    <v-col>
                        <v-card flat height= "30" color = "grey lighten-2"></v-card>  
                        <span class = " pa-8 headline font-weight-regular" color = "grey"> Se sim, quais?  </span> 
                    </v-col>
                </v-row>
                <v-row>
                    <v-col cols = "6">
                        <v-textarea
                            flat
                            auto-grow
                            placeholder = "Indique de que outros animais é dono"
                            color = "grey lighten-1" 
                            class = "pa-8"
                            rows = "2"
                        ></v-textarea>
                    </v-col>
                </v-row>
            </v-card>      

            <v-card flat height= "80" color = "white"></v-card>  

            <v-card class = "mx-auto" max-width = "1500" color = "grey lighten-2" fluid outlined rounded>
                <v-row>
                    <v-col>
                        <v-card flat height= "30" color = "grey lighten-2"></v-card>  
                        <span class = " pa-8 headline font-weight-regular" color = "grey"> Comprovativo de Morada * </span> 
                    </v-col>
                </v-row>
                <v-row>
                    <v-col cols = "6">
                        <v-file-input 
                            class = "ma-12"
                            color = "deep-orange darken-4"
                            prepend-icon=""
                            flat
                            placeholder="Adicione um comprovativo de morada"
                            prepend-inner-icon = "search">
                        </v-file-input>
                    </v-col>
                </v-row>
            </v-card>      

            <v-card flat height= "50" color = "white"></v-card>
            <v-card class = "mx-auto" max-width = "1500" flat>
                <v-row>
                    <v-col cols="12">
                        <v-checkbox color="deep-orange darken-4">
                            <template v-slot:label>
                                <div>
                                    <Termos/>
                                </div>
                            </template>
                        </v-checkbox>
                    </v-col>
                </v-row>
                <v-card-actions>
                    <v-spacer></v-spacer>
                    <v-btn class="ma-6 headline" x-large color = "deep-orange lighten-4" to="/dogs">Cancelar</v-btn>
                    <v-btn
                        class="ma-6 headline"
                        x-large
                        color="deep-orange lighten-4"
                        type="submit"
                    >Submeter Pedido</v-btn>
                </v-card-actions>  
            </v-card>      
        </div>
    
    </div>
</template>

<script>
import Termos from '../components/TermosECondicoes.vue'
export default {
    components: {
                Termos}
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