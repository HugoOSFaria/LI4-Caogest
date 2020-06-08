<template>
    <div id = "kennels" class = "kennels">
        <Navbar :id="$route.params.id"/>
        <v-card> 
            <v-img src='@/assets/canis2.png'></v-img> 
        </v-card>
        <v-card flat height= "100" color = "white"></v-card>

       <KennelsAdmin :id="$route.params.id" :id2="$route.params.id2"/>

        <Footer :id="$route.params.id"/>
    </div>
</template>


<script>

import Navbar from '@/components/NavbarFooter/NavbarAdmin.vue'
import Footer from '@/components/NavbarFooter/FooterAdmin.vue'
import KennelsAdmin from '@/components/Admin/KennelsAdmin.vue'

export default {
    components: {   Navbar, 
                    Footer,
                    KennelsAdmin
                }, 
    
}
</script>