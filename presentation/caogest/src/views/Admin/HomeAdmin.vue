<template>
    <div id = "mainpageadmin" class = "Main Page Admin">
        <NavbarAdmin/>
        <v-card> 
            <v-img src='@/assets/pedidosregisto.png'></v-img> 
        </v-card>
        <v-card flat height= "80" color = "white"></v-card>
        <v-container>
            <RegisterRequest/>
        </v-container>
        <Footer/>
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