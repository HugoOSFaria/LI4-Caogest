<template>
    <RequestKennel :id="$route.params.id"/>
</template>

<script>
// @ is an alias to /src
import RequestKennel from '@/components/Admin/RequestKennel.vue'
export default {
  name: 'PedidoRegisto',
  components: {
    RequestKennel
  }
}
</script>