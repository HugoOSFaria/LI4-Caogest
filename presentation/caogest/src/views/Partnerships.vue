<template>
    <div id = "partnerships" class = "Partnerships">
        <NavbarKennel/>
        <v-card> 
            <v-img src='../assets/parcerias.png'></v-img> 
        </v-card>
        <v-card flat height= "100" color = "white"></v-card>
        
        <v-card flat class="mx-auto" max-width="1700" fluid>
            <v-card-text class=" display-1"> A CãoGest pretende expressar o seu agradecimento a todos os voluntários e empresas que se predispõem para auxiliar os canis registados nesta plataforma, tanto em trabalho como financeiramente.</v-card-text> 
        </v-card>

        <v-card flat class = "mx-auto" height= "200" color = "white"></v-card>

        <div>
            <v-row>
                <v-col cols="12" sm="6" offset-sm="3">
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
                                            <!-- URL PARCERIAS -->
                                        </v-card-actions>
                                    </v-card>
                                </v-col>
                            </v-row>
                        </v-item-group>
                    </v-container>
                </v-col>
            </v-row>
        </div>
        <Footer/>
    </div>
</template>

<script>
import NavbarKennel from '../components/NavbarKennel.vue'
import Footer from '../components/Footer.vue'
 
export default {
    components: {
                NavbarKennel, 
                Footer
    }, 
    
}
</script>