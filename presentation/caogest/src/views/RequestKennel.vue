<template>
    <div id = "requestkennel" class = "Request Kennel">
        <NavbarAdmin/>
        <v-card flat height = "100"></v-card>
        <v-card flat height = "100" color = "brown lighten-5">
                <v-card-text class = "display-2 black--text text-center">Patinhas Canil</v-card-text>
            </v-card>
        <v-card flat class="ma-12" max-width="1500" fluid>
            <v-row>
                <v-col>
                    <v-card flat>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> E-mail: 
                                <span class = "display-1 font-weight-regular ">canilpatinhas@canil.com</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Nome: 
                                <span class = "display-1 font-weight-regular ">Patinhas Canil</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Morada: 
                                <span class = "display-1 font-weight-regular ">Rua de Itália, nº 992</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Localidade: 
                                <span class = "display-1 font-weight-regular ">Porto</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Distrito: 
                                <span class = "display-1 font-weight-regular ">Porto</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Código Postal: 
                                <span class = "display-1 font-weight-regular ">1234-121</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Capacidade Total: 
                                <span class = "display-1 font-weight-regular ">200</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Vagas Atuais: 
                                <span class = "display-1 font-weight-regular ">50</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> NIB: 
                                <span class = "display-1 font-weight-regular ">(PT50) 1111 2222 33445566778 89</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Contacto: 
                                <span class = "display-1 font-weight-regular ">222111345</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Horário de Funcionamento: </p>
                        </v-row>
                        <v-row>
                            <v-card class = "mx-auto" flat>
                                <v-row>
                                    <p class = "display-1 font-weight-bold ">Segunda-feira
                                        <span class = "display-1 font-weight-regular ">14h - 16h</span>    
                                    </p>  
                                </v-row>  
                                <v-row>
                                    <p class = "display-1 font-weight-bold ">Terça-feira
                                        <span class = "display-1 font-weight-regular ">14h - 16h</span>    
                                    </p>  
                                </v-row>  
                                <v-row>
                                    <p class = "display-1 font-weight-bold ">Quarta-feira
                                        <span class = "display-1 font-weight-regular ">14h - 16h</span>    
                                    </p>  
                                </v-row>  
                                <v-row>
                                    <p class = "display-1 font-weight-bold ">Quinta-feira
                                        <span class = "display-1 font-weight-regular ">14h - 16h</span>    
                                    </p>  
                                </v-row>  
                                <v-row>
                                    <p class = "display-1 font-weight-bold ">Sexta-feira
                                        <span class = "display-1 font-weight-regular ">14h - 16h</span>    
                                    </p>  
                                </v-row> 
                                <v-row>
                                    <p class = "display-1 font-weight-bold ">Sábado
                                        <span class = "display-1 font-weight-regular ">11h - 15h</span>    
                                    </p>  
                                </v-row> 
                                <v-row>
                                    <p class = "display-1 font-weight-bold ">Domingo
                                        <span class = "display-1 font-weight-regular ">10h - 13h</span>    
                                    </p>  
                                </v-row>    
                            </v-card>   
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Informações Adicionais: 
                                <span class = "display-1 font-weight-regular ">(Sem Informações Adicionais)</span>
                            </p> 
                        </v-row>
                    </v-card>
                </v-col>
            </v-row>
        </v-card>
        <v-card flat class = "ma-12">
            <v-row align = "end">
            <v-spacer></v-spacer>
            <v-btn class="ma-4" x-large rounded color = "deep-orange lighten-4" to="/mainpageadmin">Recusar Pedido</v-btn>
            <v-btn
                class="ma-4"
                x-large
                rounded
                color="deep-orange lighten-4"
                to = "/mainpageadmin"
            >Aceitar Pedido</v-btn>
            </v-row>
        </v-card>
        <Footer/>
    </div>
</template> 

<script>
import NavbarAdmin from '../components/NavbarAdmin.vue'
import Footer from '../components/Footer.vue'
  export default {
        components: { NavbarAdmin, 
                      Footer, 
        }
  }
</script>     