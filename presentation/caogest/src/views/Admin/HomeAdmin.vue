<template>
    <div id = "mainpageadmin" class = "Main Page Admin">
        <NavbarAdmin :id="$route.params.id"/>
        <v-card> 
            <v-img src='@/assets/pedidosregisto.png'></v-img> 
        </v-card>
        <v-card flat height= "80" color = "white"></v-card>
        <v-container>
            <RegisterRequest :id="$route.params.id"/>
        </v-container>
        <Footer :id="$route.params.id"/>
    </div>
</template>

<script>
import NavbarAdmin from '@/components/NavbarFooter/NavbarAdmin.vue'
import Footer from '@/components/NavbarFooter/Footer.vue'
import RegisterRequest from '@/components/Admin/RegisterRequest.vue'
export default {
    components: { NavbarAdmin, 
                  Footer, 
                  RegisterRequest}
}
</script>