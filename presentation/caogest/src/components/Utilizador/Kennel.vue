<template>
    <div id = "kennel" class = "Kennel">
        <Navbar :id="$route.params.id"/>
        <div>
            <v-card flat height = "200"></v-card>
            <v-card flat height = "100" color = "brown lighten-5">
                <v-card-text class = "display-2 black--text text-center">{{canil.nome}}</v-card-text>
            </v-card>
            <v-card flat height = "80"></v-card>
            <v-card flat>
                <v-row>
                    <v-spacer></v-spacer>
                    <v-col>
                        <v-btn class="ma-6 headline" x-large color = "brown lighten-4" @click="openVoluntario(canil)">Quero voluntariar-me!</v-btn>
                    </v-col>
                    <v-spacer></v-spacer>
                    <v-col>
                        <v-btn class="ma-6 headline" x-large color = "brown lighten-4" @click="horarios(canil)">Horário Voluntários</v-btn>
                    
                    </v-col>
                    <v-spacer></v-spacer>
                    <v-col>
                        <v-btn class="ma-6 headline" x-large color = "brown lighten-4" @click="informacoes(canil)">Informações</v-btn>
                    </v-col>
                    <v-spacer></v-spacer>
                    <v-col>
                        <v-btn class="ma-6 headline" x-large color = "brown lighten-4" @click="parcerias(canil)">Parcerias</v-btn>
                    </v-col>
                    <v-spacer></v-spacer>
                </v-row>
            </v-card>
             <v-card flat height = "200"></v-card>
            <v-row>
                <v-col cols="12" sm="6" offset-sm="2">
                    <v-container fluid>
                        <v-item-group
                            v-model="selected"
                            multiple
                        >
                            <v-card flat height = "100"></v-card>
                            <v-card class = " mx-auto" height = "80" width="2000" flat color = "brown lighten-5" v-if="this.disponiveis.length === 0"> 
                                <v-card-title class = "display-1 text-center justify-center"> Não existem cães registados neste canil </v-card-title>
                            </v-card>
                             <v-row>
                                <v-col
                                    v-for="obj in disponiveis"
                                    :key="obj.nome"
                                    class="d-flex child-flex"
                                    cols="4"
                                >
                                
                                    <v-card flat tile>
                                        <v-item v-slot:default="{ active, toggle }">
                                            <v-img
                                                :src="require(`@/assets/${getPath(obj)}`)"
                                                aspect-ratio="1"
                                                class="grey lighten-2"
                                                @click="toggle"
                                            >
                                                <template v-slot:placeholder>
                                                    <v-row class="fill-height ma-0" align="center" justify="center">
                                                        <v-progress-circular indeterminate color="grey lighten-5"></v-progress-circular>
                                                    </v-row>
                                                </template>  
                                            </v-img>
                                        </v-item>
                                    <v-card-actions class="justify-center">
                                       <v-btn 
                                            text
                                            x-large
                                            class = "headline"
                                            @click="openDialog(obj)"
                                        > {{obj.nome}} 
                                        </v-btn>  
                                    </v-card-actions>
                                </v-card>
                            </v-col>
                        </v-row>
                    </v-item-group>
                </v-container>      
                </v-col>
                <v-spacer></v-spacer>

                <v-col cols = "3">
                    <v-row>
                        <v-card flat>
                            <v-card-text align = "start" justify= "end" >
                                <v-card-text class="display-2 font-weight-bold black--text">Pesquisar Cães</v-card-text>
                                <v-card flat height= "50" color = "white"></v-card>
                                    <v-text-field flat color = "grey" name="input-7-1" outlined label="Raça" ></v-text-field>
                                    <v-select 
                                        color = "grey"
                                        name="input-7-1"
                                        flat outlined 
                                        :items="itemscor"
                                        label="Cor"
                                    ></v-select>
                                    <v-select 
                                        color = "grey"
                                        name="input-7-1"
                                        flat outlined 
                                        :items="itemssexo"
                                        label="Género"
                                    ></v-select>
                                    <v-text-field flat color = "grey" name="input-7-1" outlined label="Idade" ></v-text-field>
                                    <v-select 
                                        color = "grey"
                                        name="input-7-1"
                                        flat outlined 
                                        :items="itemsporte"
                                        label="Porte"
                                    ></v-select>
                                    <v-text-field flat color = "grey" name="input-7-1" outlined label="Distrito" ></v-text-field>
                            </v-card-text>
                            <v-card-actions>
                                <v-spacer></v-spacer>
                                <v-btn class="ma-6" x-large color = "brown lighten-4" @click="dialog = false">Pesquisar</v-btn>
                            </v-card-actions>
                        </v-card>
                    </v-row>
                </v-col>
            </v-row>
        </div>
        <v-dialog
            v-model="dialog" 
            fullscreen 
            hide-overlay 
            transition="dialog-bottom-transition"
        >                                                                              
            <v-card 
                class = "ma-2" 
                flat
            >
            <v-toolbar 
                height = "100" 
                color="deep-orange lighten-4"
            >
                <v-btn icon @click="dialog = false">
                    <v-icon>mdi-close</v-icon>
                </v-btn>
                <v-toolbar-title >Fechar</v-toolbar-title>
            </v-toolbar>
                                                        
            <v-card 
                color = "white" 
                height = "150" 
                flat
            ></v-card>
       
            <v-row>
                <v-col>
                    <v-card 
                    flat 
                    color = "white" 
                    class = "mx-auto" 
                    height = "800" 
                    width = "900"
                    > 
                        <v-img 
                            height = "800" 
                            width = "800" 
                            src="@/assets/example.jpg"
                        ></v-img> 
                    </v-card>    
                </v-col>

                <v-col>
                    <v-card flat>
                        <v-row>
                            <p 
                                class = " display-2 font-weight-bold" 
                                color = "grey"
                            > Nome: 
                                <span 
                                    class = "display-2 font-weight-regular "
                                >{{this.nome}}</span>
                            </p> 
                            </v-row>
                            <v-card 
                                flat 
                                color = "white" 
                                height = "100"
                            ></v-card>
                            <v-row>
                                <p 
                                    class = " display-2 font-weight-bold" 
                                    color = "grey"
                                > Raça: 
                                    <span 
                                        class = "display-2 font-weight-regular "
                                    >{{this.raca}}</span>
                                </p> 
                            </v-row>
                            <v-card 
                                flat 
                                color = "white" 
                                height = "50"
                            ></v-card>                                       
                            <v-row>
                                <p 
                                    class = " display-2 font-weight-bold" 
                                    color = "grey"
                                > Idade: 
                                    <span 
                                        class = "display-2 font-weight-regular "
                                    >{{this.idade}}</span>
                                </p> 
                            </v-row>
                            <v-card 
                                flat 
                                color = "white" 
                                height = "40"
                            ></v-card>
                            <v-row>
                                <p 
                                    class = " display-2 font-weight-bold" 
                                    color = "grey"
                                > Cor: 
                                    <span 
                                        class = "display-2 font-weight-regular "
                                    >{{this.cor}}</span>
                                </p> 
                            </v-row>
                            <v-card 
                                flat 
                                color = "white" 
                                height = "40"
                            ></v-card>                                    
                            <v-row>
                                <p 
                                    class = " display-2 font-weight-bold" 
                                    color = "grey"
                                > Porte: 
                                    <span 
                                        class = "display-2 font-weight-regular "
                                    >{{this.porte}}</span>
                                </p> 
                            </v-row>
                            <v-card 
                                flat 
                                color = "white" 
                                height = "40"
                            ></v-card>
                            <v-row>
                                <p 
                                    class = " display-2 font-weight-bold" 
                                    color = "grey"
                                > Sexo: 
                                    <span 
                                        class = "display-2 font-weight-regular "
                                    >{{this.sexo}}</span>
                                </p> 
                            </v-row>
                            <v-card 
                                flat 
                                color = "white" 
                                height = "40"
                            ></v-card>                                        
                            <v-row>
                            <p 
                                class = " display-2 font-weight-bold" 
                                color = "grey"
                            > Esterilizado: 
                                <span 
                                    class = "display-2 font-weight-regular "
                                >{{this.esterilizacao}}
                                </span>
                            </p> 
                            </v-row>
                            <v-card 
                                flat   
                                color = "white" 
                                height = "40"
                            ></v-card>
                            <v-row>
                                <p 
                                    class = " display-2 font-weight-bold" 
                                    color = "grey"
                                > Descrição: 
                                    <span 
                                        class = "display-2 font-weight-regular "
                                    >{{this.descricao}}</span>
                                </p> 
                            </v-row>
                        </v-card>
                    </v-col>
                </v-row>
            </v-card>
        </v-dialog>
        <Footer :id="$route.params.id"/>
        <v-dialog v-model="dialog2" max-width="1500" persistent>
            <v-card>
                <v-card flat light color = "brown lighten-4">
                    <v-card-title>
                        <span class="display-2 center-text ">Ser voluntário</span>
                    </v-card-title>
                </v-card>
                <v-card flat height = "50"></v-card>
                <v-card-text class = "headline"> 
                    <v-row>
                        <span class = " display-1 font-weight-black"> Requisitos e Características de um Voluntário</span>
                    </v-row>
                    <v-card flat height = "30"></v-card>
                    <v-row>  
                        <span> 
                            <v-icon color = "grey"> pets </v-icon> 
                            Para ser voluntário num canil, é importante que disponha de assiduidade regular. Tal fator é favorável, não só no que toca à experiência nos trabalhos efetuados, como na vivência com os animais. Isto porque só com o tempo é que ganhamos a confiança dos patudos, e tal é necessária quando executamos tantas tarefas em sincronia com tantos animais.
                        </span>
                    </v-row>
                    <v-card flat height = "10"></v-card>
                    <v-row>
                        <span> 
                            <v-icon color = "grey"> pets </v-icon> 
                            Com efeito, um voluntário deverá ter uma assiduidade mínima de uma vez por semana, uma vez que os animais precisam de conhecer quem anda no meio deles, e o voluntário tem que se habituar ao trabalho e logística do espaço e só através da frequência é que deixará de ser um elemento novo. 
                        </span>
                    </v-row>
                    <v-card flat height = "10"></v-card>
                    <v-row>
                        <span> 
                            <v-icon color = "grey"> pets </v-icon> 
                            Para ajudar num canil, é imprescindível que se sinta à vontade para realizar limpezas (chão, comedouros, etc.), dar banhos e escovar os animais, lavar, estender e apanhar as mantas, dar a ração aos patudos, entre outros. 
                        </span>
                    </v-row>
                    <v-card flat height = "10"></v-card>
                    <v-row>
                        <span> 
                            <v-icon color = "grey"> pets </v-icon> 
                            Trata-se de um trabalho pesado, muitas vezes debaixo de sol ou de chuva. 
                        </span>
                    </v-row>
                    <v-card flat height = "10"></v-card>
                    <v-row>
                        <span> 
                            <v-icon color = "grey"> pets </v-icon>     
                            Tenhamos em mente que falamos de animais que dependem exclusivamente do nosso trabalho e dedicação, pelo que o compromisso que assumimos inicialmente tem que ser assegurado!
                        </span>
                    </v-row>
                    <v-card flat height = "10"></v-card>
                    <v-row>
                        <span> 
                            <v-icon color = "grey"> pets </v-icon> 
                            A manutenção dos espaços e o cuidado dos animais depende do horário de funcionamento de cada canil.
                        </span>
                    </v-row>
                    <v-card flat height = "10"></v-card>
                    <v-row>
                        <span> 
                            <v-icon color = "grey"> pets </v-icon> 
                            Se se quiser dedicar, doando algum do seu tempo, durante a semana ou ao fim de semana, venha ajudar-nos. Os animais terão, assim, mais atenção e maior qualidade de vida.
                        </span>
                    </v-row>
                    <v-card flat height = "50"></v-card>
                    <v-row>
                        <span class = " display-1 font-weight-black"> Existem outras formas de voluntariado? </span>
                    </v-row>
                    <v-card flat height = "30"></v-card>
                    <v-row>
                        <span>
                            <v-icon color = "grey"> pets </v-icon> 
                            Se não tem esta disponibilidade regular, provavelmente as tarefas no abrigo não são a melhor opção de voluntariado para o seu caso. Poderá, no entanto, participar em atividades criadas pelos diversos canis, em datas e locais previamente anunciadas. Pode, ainda, optar por realizar qualquer tipo de donativo, sempre de extrema importância para todos os patudos.
                        </span>
                    </v-row>
                    <v-card flat height = "50"></v-card>
                    <v-row>
                        <v-card flat class="mx-auto font-weight-black">
                            <span>
                                AJUDE O SONHO A CONTINUAR, TORNANDO-SE VOLUNTÁRIO!
                            </span>
                        </v-card>
                    </v-row>
                </v-card-text>
                <v-card-actions>
                    <v-spacer></v-spacer>
                    <v-btn large class = "headline" color="red lighten-3 ma-4" @click="dialog2 = false">Preciso de repensar a minha decisão</v-btn>
                    <v-btn large class = "headline" color="light-green lighten-3 ma-4" @click="voluntariar()">Quero voluntariar-me!</v-btn>
                </v-card-actions>
            </v-card>
        </v-dialog>
        <div class="text-center ma-2">
            <v-snackbar
                v-model="snackbar"
                :color="color"
                :timeout="timeout"
                bottom
                multi-line
                class = "headline"
            >
                {{ text }}
                <v-btn class = "headline" text @click="fecharSnackbar">Fechar</v-btn>
            </v-snackbar>
        </div>
    </div>
</template>

<script>
import Navbar from '@/components/NavbarFooter/Navbar.vue'
import Footer from '@/components/NavbarFooter/Footer.vue'

import axios from 'axios'
const lhost = require("@/config/global").host;

export default {
    name: 'Kennel',
    props: ['id', 'id2'], 
    data: () => ({  
        fab:false,           
        itemssexo: [ 
            'Macho',
            'Fêmea',
            'Ambos',
        ],
        itemsporte: [ 
            'Pequeno',
            'Médio',
            'Grande',
            'Todos',
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
            'Todas',
        ],
        valido: [],
        items: [],
        canil: {},
        selected: [],   
        disponivel: [],     
        caes: [],
        dialog: false, 
        dialog2: false,
        alert: false, 
        idCao: "",
        nome: "",
        idade: "",
        esterilizacao: "", 
        raca: "", 
        sexo: "", 
        cor: "", 
        porte: "", 
        descricao: "", 
        estado: "", 
        fotos: [],
        snackbar: false, 
        color: "", 
        done: false, 
        timeout: 0,
        text: "",    
    }),

    components: {   Navbar, 
                    Footer,
                }, 
    created: async function(){
        try {
            let response = await axios.get(lhost + "/api/Canis/" + this.id2);
            this.canil = response.data;
            this.ready = true;
        } 
        catch (e) {
            return e;
        }
    }, 
    methods: {
        informacoes: function(canil){
            this.$router.push("/informacoes/utilizador/" + this.id + '/' + canil.email);
        }, 
        parcerias: function(canil){
            this.$router.push("/parcerias/utilizador/" + this.id + '/' + canil.email);
        },
        horarios: function(canil){
            this.$router.push("/regista/horario/" + this.id + '/' + canil.email);
        }, 
        
        onScroll (e) {
            if (typeof window === 'undefined') return
            const top = window.pageYOffset ||   e.target.scrollTop || 0
            this.fab = top > 20
        },
        toTop () {
            this.$vuetify.goTo(0)
        },
        openDialog: function(dados){
            this.idCao = dados.idCao;
            this.nome = dados.nome;
            this.raca = dados.raca;
            this.idade = dados.idade;
            this.sexo = dados.sexo;
            this.cor = dados.cor;
            this.porte = dados.porte;
            this.esterilizacao = dados.esterilizacao;
            this.descricao = dados.descricao;
            this.fotos = dados.fotos;
            this.dialog = true;
        },
        openVoluntario: function(){
            this.dialog2 = true;
        },
        voluntariar: async function(){
            try{
                var response = 
                await axios.post(lhost + "/api/Voluntarios", {
                    utilizador_user_email: this.id,
                    canil_user_email: this.id2,
              
                }); 
            console.log(JSON.stringify(response.data));
            this.text = "Registou-se como voluntário!";
            this.color = "success"; 
            this.dialog2 = false;
            this.snackbar = true; 
          }
          catch(e){
            console.log("erro: " + e);
            this.text = "Ocorreu um erro no registo, por favor tente mais tarde!";
            this.color = "warning"; 
            this.dialog2 = false;
            this.snackbar = true; 
          }
        },
        getPath: function(e) {
           return e.fotos[0].path
        },
        fecharSnackbar() {
            this.snackbar = false;
        },
        created: async function(){
            try {
                let response = await axios.get(lhost + "/api/CaesEmailCanil/" + this.id2);
                this.caes = response.data;
                this.ready = true;
            } 
                catch (e) {
                return e;
            }   
        },
    },
    computed: {
        disponiveis: function () {
            return this.caes.filter(function (disponivel) {
                return (disponivel.estado !== "Apagado" && disponivel.estado !== "Adotado")
            })
        }, 
    },                  
          
}
</script>
