<template>
    <v-container id="login">
        <v-row>
            <v-col cols="4">
                <v-text-field>
                </v-text-field>
            </v-col>
        </v-row>
        <v-row>
            <v-col  cols="4">
                <v-text-field>
                </v-text-field>
            </v-col>
        </v-row>
        <v-row>
            <v-col  cols="4">
                <v-btn type="submit">Login</v-btn>
            </v-col>
        </v-row>
    </v-container>
</template>
<script>
import { mapActions } from 'vuex';

export default {
  data() {
    return {
      payload: {},
    };
  },
  methods: {
    ...mapActions([
      'setUser',
    ]),
    login() {
      if (this.payload.login === '123456' && this.payload.password === '123456') {
        this.setUser(JSON.stringify(this.payload));
        console.log('Logou');
      }
    },
  },
};
</script>

<style lang="scss">
#login-form {
  text-align: center;
}
</style>
