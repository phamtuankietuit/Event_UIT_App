import { Stack } from "expo-router"
import { Provider } from "react-redux"
import store from "../redux/store"

const PageLayout = () => {
  return (
    <Provider store={store}>
      <Stack screenOptions={{ headerShown: false }}>
        <Stack.Screen name='add-post' options={{ headerShown: false }} />
        {/* <Stack.Screen name='update-post' options={{ headerShown: false }} /> */}
      </Stack>
    </Provider>
  )
}

export default PageLayout
