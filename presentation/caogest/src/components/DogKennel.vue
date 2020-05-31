<template>
    <div>
        <div>
        <v-row>
            <v-col cols="12" sm="6" offset-sm="2">
                    <v-btn class="ma-6" x-large color = "brown lighten-4" @click="registarCao()">Registar Cão</v-btn>
                    <v-container fluid>
                        <v-item-group
                            v-model="selected"
                            multiple
                        >
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
                                                <v-btn icon dark>
                                                    <v-icon large>
                                                        {{ active ? 'mdi-heart' : 'mdi-heart-outline' }}
                                                    </v-icon>
                                                </v-btn>

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
                        <v-card flat color = "white" height = "100"></v-card>
                            <v-row>
                                <v-btn color = "red darken-3" dark x-large class = "headline" @click="alert = !alert"> Remover Cão</v-btn>
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
                                        <v-col class="grow">Tem a certeza de que pretende remover este cão? Todos os dados serão perdidos, pelo que é uma ação irreversível.</v-col>
                                        <v-col class="shrink">
                                            <v-btn @click="removeCao()">Remover</v-btn>
                                        </v-col>
                                    </v-row>
                                </v-alert>
                            </v-row>
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
    </div>
</template>

<script>
import axios from 'axios'
const lhost = require("@/config/global").host;


export default {
    name: "DogKennel",
    props:['id'],

    data: () => ({   
        fab:false,  
        caes: [],   
        disponivel: [],     
        itemssexo: [ 
            '- Selecionar -',
            'Macho',
            'Fêmea',
        ],
        itemsporte: [ 
            '- Selecionar -',
            'Pequeno',
            'Médio',
            'Grande',
        ], 
        itemscor: [
            '- Selecionar -',
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
        ],
        dialog: false, 
        alert: false, 
        selected: [], 
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
        fotos: []  
    }),
    methods:{
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
        removeCao: async function() {
            try{ 
                var resposta = 
                await axios.put(lhost + "/api/Caes/" + this.idCao , {
                    idCao:this.idCao,
                    nome:this.nome,
                    raca:this.raca,
                    idade:this.idade,
                    sexo:this.sexo,
                    cor:this.cor,
                    porte:this.porte,
                    esterilizacao:this.esterilizacao,
                    descricao:this.descricao,
                    estado:"Apagado",
                    canil_user_email:this.id,
                    fotos: this.fotos,
                });
                console.log(JSON.stringify(resposta.data));
                this.atualiza();
                this.dialog=false;
            }
            catch(e){
                console.log("erro: " + e); 
            }
        },
        atualiza: async function(){
            try {
                let response = await axios.get(lhost + "/api/CaesEmailCanil/" + this.id);
                this.caes = response.data;
                this.ready = true;
            } 
            catch (e) {
                return e;
            }
        },
        registarCao(){
           this.$router.push("/registar/cao/" + this.id); 
        },

        getPath: function(e) {
           return e.fotos[0].path
        },
    },
    created: async function(){
        try {
        let response = await axios.get(lhost + "/api/CaesEmailCanil/" + this.id);
        this.caes = response.data;
        this.ready = true;
        } 
        catch (e) {
        return e;
        }   
    },
    computed: {
        disponiveis: function () {
        return this.caes.filter(function (disponivel) {
            return (disponivel.estado !== "Apagado")
        })
        }, 
    }    

}
</script>
