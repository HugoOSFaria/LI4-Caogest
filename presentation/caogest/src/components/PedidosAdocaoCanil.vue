<template>
    <div>
        <v-card flat height = "100" color = "brown lighten-5">
            <v-row>
                <v-card-text class = "display-2 black--text text-center">
                    {{pedido.nome_Utilizador}} 
                    <v-icon>pets</v-icon> 
                    {{pedido.cao_idCao}}
                </v-card-text>
            </v-row>
        </v-card>
        <v-card flat height = "50"></v-card>
        <v-card flat class="ma-12" max-width="3000" fluid>
            <v-row>
                <v-col>
                    <v-card flat color = "white" class = "mx-auto" height = "800" width = "900"> 
                         <v-img height = "800" width = "800" src='@/assets/example.jpg'></v-img> 
                    </v-card>
                </v-col>
                <v-col>
                    <v-card flat>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Nome Completo: 
                                <span class = "display-1 font-weight-regular ">{{pedido.nome_Utilizador}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Nome Cão: 
                                <span class = "display-1 font-weight-regular ">{{pedido.cao_idCao}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Número do Cartão de Cidadão: 
                                <span class = "display-1 font-weight-regular ">{{pedido.cc}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Tipo de Moradia: 
                                <span class = "display-1 font-weight-regular ">{{pedido.tipoMoradia}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Espaço exterior ou equivalente: 
                                <span class = "display-1 font-weight-regular ">{{pedido.exterior}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> A sua habitação é: 
                                <span class = "display-1 font-weight-regular ">{{pedido.habitacao}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Em caso de alugada ou condomínio, tem permissão para ter animais: 
                                <span class = "display-1 font-weight-regular ">{{pedido.permissao}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Pretende um cão para: 
                                <span class = "display-1 font-weight-regular ">{{pedido.motivo}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Em caso de ausência para férias, trabalho ou outra, o seu cão:
                                <span class = "display-1 font-weight-regular ">{{pedido.ausencia}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Tem alguém alérgico a cães na família: 
                                <span class = "display-1 font-weight-regular ">{{pedido.alergia}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> É dono de mais algum animal: 
                                <span class = "display-1 font-weight-regular ">{{pedido.donoAnimal}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Se sim, quais: 
                                <span class = "display-1 font-weight-regular ">{{pedido.descAnimais}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Comprovativo de Morada: 
                                <span class = "display-1 font-weight-regular ">{{pedido.comprovativo}}</span>
                            </p> 
                        </v-row>
                    </v-card>
                </v-col>
            </v-row>
        </v-card>
         <v-card flat class = "mx-auto">
            <v-row justify = "end">
                <v-btn v-if="pedido.estado === 'Pendente'" class="ma-4" x-large color = "deep-orange lighten-4" @click="rejeitarRegisto()">
                    Recusar Registo
                </v-btn>
                <v-btn v-else class="ma-4" x-large disabled>
                    Recusar Registo
                </v-btn>
                <v-btn v-if="pedido.estado === 'Pendente'" type="button" class="ma-4" x-large color = "deep-orange lighten-4" @click="aceitarRegisto()">
                    Aceitar Registo
                </v-btn>
                <v-btn v-else class="ma-4" x-large disabled>
                    Aceitar Registo
                </v-btn>
            </v-row>
        </v-card>
    </div>
</template>

<script>

import axios from 'axios'
const lhost = require("@/config/global").host;

export default {
    data: () => ({
        pedido: {},
    }),
    name: 'EstadoPedidos',
    props: ['id'], 
    created: async function(){
        try {
            let response = await axios.get(lhost + "/api/Adocoes/" + this.id);
            this.pedido = response.data;
            JSON.stringify(this.pedido.estado);
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
                await axios.put(lhost + "/api/Adocoes/" + this.id , {
                    npedido: vm.pedido.npedido, 
                    data: vm.pedido.data, 
                    estado: "Aceite", 
                    cao_idCao: vm.pedido.cao_idCao, 
                    permissao: vm.pedido.permissao, 
                    alergia: vm.pedido.alergia, 
                    descAnimais: vm.pedido.descAnimais, 
                    ausencia: vm.pedido.ausencia,
                    habitacao: vm.pedido.habitacao, 
                    exterior: vm.pedido.exterior, 
                    tipoMoradia: vm.pedido.tipoMoradia, 
                    motivo: vm.pedido.motivo, 
                    utilizador_user_email: vm.pedido.utilizador_user_email, 
                    comprovatido: vm.pedido.comprovativo, 
                    donoAnimal: vm.pedido.donoAnimal,
                });
                console.log(JSON.stringify(resposta.data));
           }
           catch(e){
            console.log("erro: " + e); 
          }
        },
    }
}
</script>     