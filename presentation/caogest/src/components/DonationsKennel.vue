<template>
    <div id = "donationskennel" class = "donationsKennel">
            <v-card> 
                <v-img src='@/assets/donationskennel.png'>
                    <v-card flat height= "400" max-width="800" color = "transparent"></v-card>
                    <v-row class="fill-height"
                        align="center"
                        justify="center">
                        <v-col>
                            <v-row
                                class="fill-height"
                                align="center"
                                justify="center"
                            >
                                <div class="display-4 font-weight-bold white--text">Donativos</div>
                            </v-row>
                            <v-card flat height= "70" color = "transparent"></v-card>
                            <v-row class="fill-height"
                                align="center"
                                justify="center">
                                <div class="display-2 font-weight-bold white--text">Os donativos representam a principal e quase única fonte de receita dos canis para a </div>
                                <div class = "display-2 font-weight-bold white--text">prossecução das suas finalidades e dos programas e atividades que, diariamente,</div>
                                <div class = "display-2 font-weight-bold white--text"> desenvolve em prol do bem estar dos cães. </div>
                            </v-row>
                        </v-col>
                    </v-row>
                </v-img>
            </v-card>
            <v-card flat height= "150" color = "white"></v-card>

            <p class="my-5 display-2 font-weight-bold text-center">Donativos Monetários Realizados</p>
            <v-card flat height="40" color="white"></v-card>

                <v-container class="my-5">
                    <v-layout row class="mb-3"> 
                        <v-tooltip top>
                            <template v-slot:activator="{ on }">
                                <v-btn class = "ma-2" text @click="sortBy('valor')" v-on="on">
                                    <v-icon left small>euro</v-icon>    
                                    <span class = "caption text-lowercase">Por quantia</span>
                                </v-btn>  
                            </template>
                            <span>Ordenar pedidos por quantia doada</span> 
                        </v-tooltip>

                        <v-tooltip top>    
                            <template v-slot:activator="{ on }">
                                <v-btn class = "ma-2" text @click="sortBy('data')" v-on="on">
                                    <v-icon left small>today</v-icon>    
                                    <span class = "caption text-lowercase">Por data</span>
                                </v-btn> 
                            </template>
                            <span>Ordenar pedidos por data de submissão</span>
                        </v-tooltip>    
                    </v-layout>

                <v-card flat height = "100"></v-card>
                 <v-card class = " mx-auto" height = "80" width="2000" flat color = "brown lighten-5" v-if="this.donativos.length === 0"> 
                    <v-card-title class = "display-1 text-center justify-center"> Não foram realizados donativos monetários </v-card-title>
                </v-card>
                <v-card flat v-else v-for="donativo in donativos" :key="donativo.nome">
                    <v-layout row wrap class="pa-7 donativo">
                    <v-flex xs12 md4>
                        <div class="caption grey--text">Nome Donatário</div>
                        <div class="headline" >{{ donativo.utilizador_user_email }}</div>
                    </v-flex>
                    <v-flex xs6 sm4 md4>
                        <div class="caption grey--text">Valor do Donativo</div>
                        <div class="headline">{{ donativo.valor }}</div>
                    </v-flex>
                    <v-flex xs6 sm4 md4>
                        <div class="caption grey--text">Data do Donativo</div>
                        <div class="headline">{{date(donativo.data) }}</div>
                    </v-flex>
                    </v-layout>
                    <v-divider></v-divider>
                </v-card>
                <v-btn
                    v-scroll="onScroll"
                    x-large
                    v-show="fab"
                    fab
                    depressed
                    fixed
                    bottom
                    right
                    class = "ma-6"
                    color="deep-orange lighten-4"
                    @click="toTop"
                >
                    <v-icon>keyboard_arrow_up</v-icon>
                </v-btn>
                </v-container>
    </div>
</template>

<script>
const lhost = require("@/config/global").host;
import axios from "axios";
import moment from 'moment/moment';

export default {
    name:"Donations", 
    props:['id'],
  data() {
    return {
        fab:false,
        donativos: []
    };
  },
  methods: {
    sortBy(prop){
          this.donativos.sort((a,b) => a[prop] < b[prop] ? 1 : -1)
    },
    onScroll (e) {
            if (typeof window === 'undefined') return
            const top = window.pageYOffset ||   e.target.scrollTop || 0
            this.fab = top > 20
        },
    toTop () {
        this.$vuetify.goTo(0)
    },
    date: function (date) {
        return moment(date).locale("pt").format('LL');
    },
    }, 
    created: async function(){
        try {
            let response = await axios.get(lhost + "/api/Donativos/" + this.id);
            this.donativos = response.data;
            this.ready = true;
        } 
        catch (e) {
        return e;
        }
    },        
};
</script>

<style>

</style>
