import { ScrollView, View } from "react-native"
import LogoWithName from "../assets/images/Logo-with-name.png"
import * as Animatable from "react-native-animatable"
import { useRouter } from "expo-router"
import { useEffect } from "react"
import * as asyncStorage from "./store/asyncStorage"

export default function App() {
  const router = useRouter()

  const checkAuth = async () => {
    const result = await asyncStorage.getIsLogin()

    if (result && result === "true") {
      router.replace("home")
    } else {
      router.replace("(auth)/sign-in")
    }
  }

  useEffect(() => {
    setTimeout(() => {
      checkAuth()
    }, 3000)
  }, [])

  // useEffect(() => {
  //   setTimeout(() => {
  //     //router.replace("(page)/add-post")
  //     // router.replace("(auth)/sign-in")
  //     // router.replace("home")
  //     // router.replace("(page)/page-detail")
  //     // router.replace("(page)/camera")
  //   }, 3000)
  // })

  return (
    <ScrollView contentContainerStyle={{ height: "100%" }}>
      <View className='h-full w-full items-center justify-center bg-white'>
        <Animatable.Image
          animation='bounceIn'
          duration={1000}
          easing='ease-in-out'
          className='h-72 w-72'
          source={LogoWithName}
        />
      </View>
    </ScrollView>
  )
}
