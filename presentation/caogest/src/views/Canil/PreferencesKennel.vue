<template>
    <div id = "preferences" class = "preferences">
        <NavbarKennel/>
            <v-card flat height= "60" color = "white"></v-card>

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
                                Canil 1
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
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> CAPACIDADE TOTAL </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                400
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <CapacityChange/>  
                        </v-col>
                    </v-row>
                    <v-divider></v-divider>

                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> CAPACIDADE ATUAL </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                200
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <CapacityChange/>  
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
                    <v-divider></v-divider>

                    <v-row>
                       <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> CONTACTO </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                911111111
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <ContactChange/>  
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
                                canil.1@canil.com
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
                                Rua de Canil
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
                                Canil
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
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> DISTRITO </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                Canil
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <DistrictChange/>  
                        </v-col>
                    </v-row>
                    <v-divider></v-divider>

                    <v-row>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey"> NIB </p> 
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <p class = " pa-8 headline font-weight-regular" color = "grey darken-4">
                                123443211234567890123
                            </p>
                        </v-col>
                        <v-spacer></v-spacer>
                        <v-col>
                            <NIBChange/>  
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
                            <v-btn>Remover</v-btn>
                            </v-col>
                        </v-row>
                    </v-alert>
                </v-card>
                </div>
                   
                

        <Footer/>
    </div>
</template>

<script>
import NavbarKennel from '@/components/NavbarFooter/NavbarKennel.vue'
import Footer from '@/components/NavbarFooter/FooterKennel.vue'
import NameChange from '@/components/EditarDados/NameChange.vue'
import AddressChange from '@/components/EditarDados/AddressChange.vue'
import PasswordChange from '@/components/EditarDados/PasswordChange.vue'
import CityChange from '@/components/EditarDados/CityChange.vue'
import DistrictChange from '@/components/EditarDados/DistrictChange.vue'
import NIBChange from '@/components/EditarDados/NIBChange.vue'
import ContactChange from '@/components/EditarDados/ContactChange.vue'
import CapacityChange from '@/components/EditarDados/CapacityChange.vue'

export default {
    data: () => ({             
         items: [
            { title: 'Palavra-Passe', icon: 'vpn_key'},
            { title: 'Nome', icon: 'face'},
            { title: 'Morada', icon: 'house'},
            { title: 'Concelho', icon: 'business' },
            { title: 'Distrito', icon: 'business'},
            { title: 'Capacidade', icon: 'plus_one'},
            { title: 'NIB', icon: 'account_balance_wallet' },
            { title: 'Contacto', icon: 'phone'}
            ],
        dialog:false,
        alert: false,
    }),
    components: {   NavbarKennel, 
                    Footer, 
                    NameChange,
                    ContactChange,
                    AddressChange,
                    PasswordChange,
                    CityChange,
                    DistrictChange,
                    NIBChange, 
                    CapacityChange},   
   
   
            
}
</script>