import { Stack } from "expo-router"

const PageLayout = () => {
  return (
    <Stack screenOptions={{ headerShown: false }}>
      <Stack.Screen name='add-post' options={{ headerShown: false }} />
    </Stack>
  )
}

export default PageLayout
