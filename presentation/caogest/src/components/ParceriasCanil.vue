<template>
    <div>
        <v-row>
            <v-col cols="12" sm="8" offset-sm="2" >
                <v-container fluid>
                    <v-card class = " mx-auto" height = "80" width="2000" flat color = "brown lighten-5" v-if="this.items.length === 0"> 
                        <v-card-title class = "display-1 text-center justify-center"> Não existem parcerias associadas. </v-card-title>
                    </v-card>
                        <v-item-group
                        v-model="selected"
                        multiple
                    >
                        <v-row>
                            <v-col
                                class="d-flex child-flex"
                                cols="4"
                                v-for="item in items"
                                :key="item.nome">
                                <v-card flat tile>
                                    <v-item v-slot:default="{ active, toggle }">
                                        <v-img
                                            :src="item.pathLogo"
                                            aspect-ratio="1"
                                            class="white"
                                            contain
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
                                                <v-btn text light :href="item.url"> {{item.nome}} </v-btn>  
                                    </v-card-actions>
                                </v-card>
                            </v-col>
                        </v-row>
                    </v-item-group>
                </v-container>      
            </v-col>
        </v-row>
    </div>
</template>

<script>
import axios from 'axios'
import store from '@/store.js'
const lhost = require("@/config/global").host;
 
export default {
    data: () => ({  
        items: [],
        selected: [],  
        fab:false, 
    }),
    name: 'Parcerias',    
    props: ['id'], 
    methods:{
        
    },
    created: async function(){
        try {
            let response = await axios.get(lhost + "/api/CP/" + this.id,
            { headers: 
              { "Authorization": 'Bearer ' + store.getters.token }
            });
            this.items = response.data;
            this.ready = true;
        } 
        catch (e) {
           if(e.message == "Request failed with status code 401"){
                this.$store.commit("limpaStore");
                this.$router.push("/");
            }
        }
    },  
    
}
</script>