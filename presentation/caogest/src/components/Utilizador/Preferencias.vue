<template>
    <div>
                <v-card flat class="mx-auto" max-width="1500" fluid>
                    <p class = "display-2 font-weight-regular text-center" color = "grey darken-4"> Informações Pessoais</p>
                </v-card>

                <v-card flat height= "100" color = "white"></v-card>    

                <v-card class = "mx-auto" max-width = "1500" fluid outlined rounded>
                    
                    <p class = " pa-8 display-1 font-weight-regular" color = "grey darken-4"> Perfil </p>
                    <v-card flat height= "80" color = "white"></v-card>    
                    
                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> NOME </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                {{dados.nome}}
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <NameChange/>  
                        </v-col>
                    </v-row>
                    <v-divider></v-divider>

                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> ANIVERSÁRIO </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                {{date(dados.data_de_nascimento)}}
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <BirthChange/>  
                        </v-col>
                    </v-row>
                    <v-divider></v-divider>

                    <v-row>
                       <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> PALAVRA-PASSE </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                **********
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <PasswordChange/>  
                        </v-col>
                    </v-row>
                </v-card>    

                 <v-card flat height= "100" color = "white"></v-card>          

                 <v-card class = "mx-auto" max-width = "1500" fluid outlined rounded>
                    
                    <p class = " pa-8 display-1 font-weight-regular" color = "grey darken-4"> Informações de Contacto </p>
                    <v-card flat height= "20" color = "white"></v-card>    
                    
                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> EMAIL </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                {{dados.email}}
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <v-btn class="ma-5" disabled text fab></v-btn>
                        </v-col>
                        
                    </v-row>
                    <v-divider></v-divider>

                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> MORADA </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                {{dados.rua}}
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <AddressChange/>  
                        </v-col>
                    </v-row>
                    <v-divider></v-divider>

                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> CONCELHO </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                {{dados.localidade}}
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <CityChange/>  
                        </v-col>
                    </v-row>
                    <v-divider></v-divider>

                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> NÚMERO DE CARTÃO DE CIDADÃO </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                {{dados.cc}}
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <NIFChange/>  
                        </v-col>
                    </v-row>
                </v-card>     
                <v-card flat height= "100" color = "white"></v-card>          
                <v-card flat class = "mx-auto" max-width = "1500" fluid>
                <v-btn color = "red darken-3" dark x-large class = "headline" @click="alert = !alert"> Remover Conta</v-btn>
                    <v-alert
                        :value="alert"
                        color="red"
                        prominent
                        dark
                        transition="scale-transition"
                        type = "error"
                        text
                    >
                        <v-row align="center">
                            <v-col class="grow">Tem a certeza de que pretende remover a sua conta? Todos os dados serão perdidos, pelo que é uma ação irreversível.</v-col>
                            <v-col class="shrink">
                            <v-btn to='/'>Remover</v-btn>
                            </v-col>
                        </v-row>
                    </v-alert>
                </v-card>
            </div>
</template>

<script>
import NameChange from '@/components/EditarDados/NameChange.vue'
import BirthChange from '@/components/EditarDados/BirthChange.vue'
import AddressChange from '@/components/EditarDados/AddressChange.vue'
import PasswordChange from '@/components/EditarDados/PasswordChange.vue'
import CityChange from '@/components/EditarDados/CityChange.vue'
import NIFChange from '@/components/EditarDados/NIFChange.vue'
import moment from 'moment/moment'
import axios from 'axios'
const lhost = require("@/config/global").host;

export default {
    name: 'Preferencias',    
    props: ['id'], 
    data: () => ({             
        dialog:false,
        alert: false,
        dados: {},
    }),
    components: {  
        NameChange,
        BirthChange,
        AddressChange,
        PasswordChange,
        CityChange,
        NIFChange
    },   
    methods:{
        date: function (date) {
            return moment(date).locale("pt").format('L');
        },
    },
   created: async function(){
    try {
      let response = await axios.get(lhost + "/api/Utilizadors/" + this.id);
      this.dados = response.data;
      this.ready = true;
    } 
    catch (e) {
      return e;
    }
   }       
}
</script>