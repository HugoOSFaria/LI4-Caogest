<template>
    <div id = "kennel" class = "Kennel">
        <Navbar/>
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
                        <v-btn class="ma-6 headline" x-large color = "brown lighten-4">Quero voluntariar-me!</v-btn>
                    </v-col>
                    <v-spacer></v-spacer>
                    <v-col>
                        <v-btn class="ma-6 headline" x-large color = "brown lighten-4" to="/registahorario">Horário Voluntários</v-btn>
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
                            <v-row>
                                <v-col
                                    v-for="n in 9"
                                    :key="n"
                                    class="d-flex child-flex"
                                    cols="4"
                                >
                                    <v-card flat tile>
                                        <v-item v-slot:default="{ active, toggle }">
                                            <v-img
                                                :src="`https://picsum.photos/500/300?image=${n * 5 + 10}`"
                                                :lazy-src="`https://picsum.photos/10/6?image=${n * 5 + 10}`"
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
                                        <Dog/>
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
                                    <v-text-field flat color = "grey" name="input-7-1" outlined label="Localidade" ></v-text-field>
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
        <Footer/>
    </div>
</template>

<script>
import Navbar from '../components/NavbarAdmin.vue'
import Footer from '../components/FooterAdmin.vue'
import Dog from '../components/Dog.vue'

import axios from 'axios'
const lhost = require("@/config/global").host;

export default {
    data: () => ({             
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
        items: [],
        canil: {},
        selected: [],   
    }),
    name: 'KennelsAdmin',
    props: ['id'], 
    components: {   Navbar, 
                    Footer,
                    Dog }, 
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
    methods: {
        informacoes: function(canil){
            this.$router.push("/informations/" + canil.user_email);
        }, 
        parcerias: function(canil){
            this.$router.push("/parcerias/" + canil.user_email);
        }, 
    }                
            
}
</script>