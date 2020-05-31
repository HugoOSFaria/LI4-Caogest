<template>
    <div id = "requestkennel" class = "Request Kennel" >
        <NavbarAdmin/>
        <v-card flat height = "100"></v-card>
        <v-card flat height = "100" color = "brown lighten-5">
                <v-card-text class = "display-2 black--text text-center">{{canil.nome}}</v-card-text>
            </v-card>
        <v-card flat class="ma-12" max-width="1500" fluid>
            <v-row>
                <v-col>
                    <v-card flat>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> E-mail: 
                                <span class = "display-1 font-weight-regular ">{{canil.email}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Nome: 
                                <span class = "display-1 font-weight-regular ">{{canil.nome}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Morada: 
                                <span class = "display-1 font-weight-regular ">{{canil.rua}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Localidade: 
                                <span class = "display-1 font-weight-regular ">{{canil.localidade}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Distrito: 
                                <span class = "display-1 font-weight-regular ">{{canil.distrito}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Capacidade Total: 
                                <span class = "display-1 font-weight-regular ">{{canil.capacidadeTotal}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Vagas Ocupadas: 
                                <span class = "display-1 font-weight-regular ">{{canil.capacidadeOcupada}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> NIB: 
                                <span class = "display-1 font-weight-regular ">{{canil.nib}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Contacto: 
                                <span class = "display-1 font-weight-regular ">{{canil.contacto}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Horário de Funcionamento: </p>
                        </v-row>

                                <v-col v-for="hor in sortedArray" :key = "hor.dia">
                                    <v-row>
                                        <p class = "display-1 font-weight-bold ">{{dia(hor.dia)}}
                                            <span class = "display-1 font-weight-regular ">{{date(hor.dataInicio)}} - {{date(hor.dataFim)}}</span>    
                                        </p>  
                                    </v-row>    
                                </v-col>
           
                    </v-card>
                </v-col>
            </v-row>
        </v-card>
        <v-card flat class = "ma-12">
            <v-row align = "end">
            <v-spacer></v-spacer>
            <v-btn v-if="canil.estado === 'Pendente'" class="ma-4" x-large color = "deep-orange lighten-4" @click="rejeitarRegisto">
                Recusar Registo
            </v-btn>
            <v-btn v-else class="ma-4" x-large disabled>
                Recusar Registo
            </v-btn>
             <v-btn v-if="canil.estado === 'Pendente'" type="button" class="ma-4" x-large color = "deep-orange lighten-4" @click="aceitarRegisto">
                Aceitar Registo
            </v-btn>
            <v-btn v-else class="ma-4" x-large disabled>
                Aceitar Registo
            </v-btn>
           
            </v-row>
        </v-card>
        <Footer/>
    </div>
</template> 

<script>
import NavbarAdmin from '@/components/NavbarFooter/NavbarAdmin.vue'
import Footer from '@/components/NavbarFooter/Footer.vue'

import axios from 'axios'
import moment from 'moment/moment';
const lhost = require("@/config/global").host;

export default {
    data: () => ({
        canil: {},
        horario:[], 
    }),
    name: 'PedidoRegisto',
    props: ['id'], 
    components: { NavbarAdmin, 
                  Footer, 
    },
    
    created: async function(){
        try {
            let response = await axios.get(lhost + "/api/Canis/" + this.id);
            this.canil = response.data;
            this.horario = response.data.horarios;
            this.ready = true;
        } 
        catch (e) {
            return e;
        }
    },
    methods: {
        aceitarRegisto: async function(){
           try{ 
                let vm = this;
                var resposta = 
                await axios.put(lhost + "/api/Canis/" + this.id , {
                    email: vm.canil.email,
                    nib: vm.canil.nib, 
                    nome: vm.canil.nome, 
                    capacidadeOcupada: vm.canil.capacidadeOcupada,
                    capacidadeTotal: vm.canil.capacidadeTotal, 
                    distrito: vm.canil.distrito, 
                    rua: vm.canil.rua, 
                    localidade: vm.canil.localidade, 
                    contacto: vm.canil.contacto, 
                    estado: "Aceite"
                });
                console.log(JSON.stringify(resposta.data));
           }
           catch(e){
            console.log("erro: " + e); 
          }
        },
        rejeitarRegisto: async function(){
           try{ 
                let vm = this;
                var resposta = 
                await axios.put(lhost + "/api/Canis/" + this.id , {
                    email: vm.canil.email,
                    nib: vm.canil.nib, 
                    nome: vm.canil.nome, 
                    capacidadeOcupada: vm.canil.capacidadeOcupada,
                    capacidadeTotal: vm.canil.capacidadeTotal, 
                    distrito: vm.canil.distrito, 
                    rua: vm.canil.rua, 
                    localidade: vm.canil.localidade, 
                    contacto: vm.canil.contacto, 
                    estado: "Rejeitado"
                });
                console.log(JSON.stringify(resposta.data));
           }
           catch(e){
            console.log("erro: " + e); 
          }
        },
        date: function (date) {
            return moment(date).locale("pt").format('LT');
        },
        dia: function (num) {
            if(num === 1) return "Segunda-feira"
            else if (num === 2) return "Terça-feira";
            else if (num === 3) return "Quarta-feira"; 
            else if (num === 4) return "Quinta-feira"; 
            else if (num === 5) return "Sexta-feira"; 
            else if (num === 6) return "Sábado";
            return "Domingo";
        }
    }, 
    computed: {
        sortedArray: function() {
            function compare(a, b) {
            if (a.dia < b.dia)
                return -1;
            if (a.dia > b.dia)
                return 1;
            return 0;
            }

            return this.horario.slice(0).sort(compare);
        }
    }, 
}
</script>     