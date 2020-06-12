<template>
    <div>
            <v-row >
                <v-col 
                    cols="12" 
                    sm="6" 
                    offset-sm="2" 
                >
                    <v-container fluid>
                        <v-item-group
                            v-model="selected"
                            multiple
                        >
                            <v-row>
                                <v-col
                                    class="d-flex child-flex"
                                    cols="4"
                                    v-for="obj in disponiveis"
                                    :key="obj.nome"
                                    >
                                    <v-card flat tile>
                                        <v-item 
                                            v-slot:default="{ active, toggle }"
                                        >
                                            <v-img
                                                :src="require(`@/assets/${getPath(obj)}`)"
                                                aspect-ratio="1"
                                                class="grey lighten-2"
                                                @click="toggle"
                                            >
                                                <template v-slot:placeholder>
                                                    <v-row 
                                                        class="fill-height ma-0" 
                                                        align="center" 
                                                        justify="center"
                                                    >
                                                        <v-progress-circular 
                                                            indeterminate 
                                                            color="grey lighten-5"
                                                        ></v-progress-circular>
                                                    </v-row>
                                                </template>
                                            </v-img>
                                        </v-item>
                                        
                                        <v-row justify="center">
                                            <v-btn 
                                                text
                                                x-large
                                                class = "headline"
                                                @click="cao(obj)"
                                            > {{obj.nome}} 
                                            </v-btn>  
                                        </v-row>
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
</template>

<script>

import axios from 'axios'
const lhost = require("@/config/global").host;

export default {
    props: ['item', 'id'],
    data: () => ({     
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
        items: [],
      selected: [],  
      nome: "",
      idade: "",
      esterilizacao: "", 
      raca: "", 
      sexo: "", 
      cor: "", 
      porte: "", 
      descricao: "",
      fotos:[]
    }),
    created: async function(){
        try {
        let response = await axios.get(lhost + "/api/Caes");
        this.items = response.data;
        this.ready = true;
        } 
        catch (e) {
        return e;
        }
    },   
    methods:{
        getPath: function(e) {
           return e.fotos[0].path
        },
        cao: function(obj){
            this.$router.push("/cao/admin/" + this.id + '/' + obj.idCao );
        },
        
    },
    computed: {
        disponiveis: function () {
        return this.items.filter(function (disponivel) {
            return (disponivel.estado !== "Apagado" && disponivel.estado != "Adotado")
        })
        }, 
    }      
}
</script>