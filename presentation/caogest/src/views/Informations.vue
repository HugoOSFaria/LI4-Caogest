<template>
    <div id = "informations" class = "informations">
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
                                Rua da Ilha nº 111
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                    </v-row>
                    <v-divider></v-divider>

                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> CÓDIGO POSTAL </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                0000-001
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
                                Braga
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
                                Braga
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
                                canil123@canil.com
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
                                251111111
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
                               (PT50) 1234 1234 09876543211 12
                            </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                    </v-row>
                </v-card>     
            </div>
        <Footer/>
    </div>
</template>

<script>
import Navbar from '../components/Navbar.vue'
import Footer from '../components/Footer.vue'

export default {
    data: () => ({  
    }),
    components: {   Navbar, 
                    Footer, 
                    },   
   
   
            
}
</script>