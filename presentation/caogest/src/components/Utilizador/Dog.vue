<template>
    <div>   
    <div>
        <v-row align = "center" justify = "center">
            <v-col>
                    <v-container fluid>
                        <v-item-group
                            v-model="selected"
                            multiple
                        >
                            <v-card flat height = "100"></v-card>
                            <v-card class = " mx-auto" height = "150" width="1770" flat color = "brown lighten-5" v-if="this.disponiveis.length === 0"> 
                                <v-card-title class = "display-1 text-center justify-center"> Adotar um cão é um processo longo e cuidado. Adicione aqui os patudos que pretende conhecer e torná-los </v-card-title>
                                <v-card-title class = "display-1 justify-center">parte da sua família.</v-card-title>
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
                                                <v-btn icon dark>
                                                    <v-icon large>
                                                        {{ active ? 'mdi-heart-outline' : 'mdi-heart' }}
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
                            :src="require(`@/assets/${getPath2()}`)"
                        ></v-img> 
                        <v-card 
                            flat 
                            color = "white" 
                            height = "100"
                        ></v-card>
                        <v-row>
                            <v-btn 
                                x-large 
                                height = "100" 
                                class = "display-2" 
                                color = "deep-orange lighten-5" 
                                @click="adotar(this.canil_user_email)"
                            > Quero Adotar! </v-btn>
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
    name: "Dog",
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
        canil_user_email: "",
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
            this.canil_user_email = dados.canil_user_email;
            this.dialog = true;
        },
        atualiza: async function(){
            try {
                let response = await axios.get(lhost + "/api/Favoritos/" + this.id);
                this.caes = response.data;
                this.ready = true;
            } 
            catch (e) {
                return e;
            }
        },
        getPath: function(e) {
           return e.fotos[0].path
        },
        getPath2: function() {
           alert(JSON.stringify(this));
           
        },
        adotar: function(email){
            alert(JSON.stringify(email));
            this.$router.push("/registar/cao/" + email); 

        }
    },
    created: async function(){
        try {
        let response = await axios.get(lhost + "/api/Favoritos/" + this.id);
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
            return (disponivel.estado !== "Apagado" && disponivel.estado != "Adotado")
        })
        }, 
    }    

}
</script>
