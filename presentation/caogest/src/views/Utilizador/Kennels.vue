<template>
    <div id = "kennels" class = "kennels">
        <Navbar :id="$route.params.id"/>
        <v-card> 
            <v-img src='@/assets/canis2.png'></v-img> 
        </v-card>
        <v-card flat height= "100" color = "white"></v-card>

        <Kennels :id="$route.params.id" />

        <Footer :id="$route.params.id"/>
    </div>
</template>


<script>

import Navbar from '@/components/NavbarFooter/Navbar.vue'
import Footer from '@/components/NavbarFooter/Footer.vue'
import Kennels from '@/components/Utilizador/Kennels.vue'



export default {
    components: {   Navbar, 
                    Footer,
                    Kennels
                
                }, 
}
</script>