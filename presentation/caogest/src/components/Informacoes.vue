<template>
    <div id = "informacoes" class = "informacoes">
        <Navbar/>

            <v-card flat height= "60" color = "white"></v-card>

            <div>
                <v-card flat class="mx-auto" max-width="1500" fluid>
                    <p class = "display-2 font-weight-regular text-center" color = "grey darken-4"> Informações </p>
                </v-card>

                <v-card flat height= "100" color = "white"></v-card>    

                <v-card class = "mx-auto" max-width = "1500" fluid outlined rounded>
                    
                    <p class = " pa-8 display-1 font-weight-regular" color = "grey darken-4"> Morada </p>
                    <v-card flat height= "80" color = "white"></v-card>    
                    
                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> RUA </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                {{canil.rua}}
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                    </v-row>
                    <v-divider></v-divider>

                    <v-row>
                       <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> CONCELHO </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                {{canil.localidade}}
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                    </v-row>
                    <v-divider></v-divider>

                    <v-row>
                       <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> DISTRITO </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                {{canil.distrito}}
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                    </v-row>
                </v-card>    

                 <v-card flat height= "100" color = "white"></v-card>          

                 <v-card class = "mx-auto" max-width = "1500" fluid outlined rounded>
                    
                    <p class = " pa-8 display-1 font-weight-regular" color = "grey darken-4"> Contactos </p>
                    <v-card flat height= "20" color = "white"></v-card>    
                    
                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> EMAIL </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                {{canil.user_email}}
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                    </v-row>
                    <v-divider></v-divider>

                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> TELEFONE </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                {{canil.contacto}}
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                    </v-row>
                 </v-card>

                 <v-card flat height= "100" color = "white"></v-card>          

                 <v-card class = "mx-auto" max-width = "1500" fluid outlined rounded>
                    <p class = " pa-8 display-1 font-weight-regular" color = "grey darken-4"> Número de Identificação Bancária </p>
                    <v-card flat height= "20" color = "white"></v-card>    

                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                               {{canil.nib}}
                            </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                    </v-row>

                 </v-card>
                
                 <v-card flat height= "100" color = "white"></v-card>   

                <v-card class = "mx-auto" max-width = "1500" fluid outlined rounded>
                    
                    <p class = " pa-8 display-1 font-weight-regular" color = "grey darken-4"> Ocupação </p>
                    <v-card flat height= "20" color = "white"></v-card>    
                        
                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> VAGAS TOTAIS </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                {{canil.capacidadeTotal}}
                            </p>
                        </v-col>
                    </v-row>
                    <v-spacer></v-spacer>
                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> VAGAS OCUPADAS </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                {{canil.capacidadeOcupada}}
                            </p>
                        </v-col>
                    </v-row>
                </v-card>
    
            </div>
        <Footer/>
    </div>
</template>

<script>
import Navbar from '../components/NavbarAdmin.vue'
import Footer from '../components/FooterAdmin.vue'
import axios from 'axios'
const lhost = require("@/config/global").host;

export default {
    data: () => ({
        canil: {},
    }),
    name: 'Informations',
    props: ['id'], 
    components: { Navbar, 
                  Footer, 
    },
    created: async function(){
        try {
            let response = await axios.get(lhost + "/api/Canis/" + this.id);
            this.canil = response.data;
            this.ready = true;
        } 
        catch (e) {
            return e;
        }
    },  
   
   
            
}
</script>