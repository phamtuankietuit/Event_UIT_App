import { Stack } from "expo-router"

const PageLayout = () => {
  return (
    <Stack screenOptions={{ headerShown: false }}>
      <Stack.Screen name='add-post' options={{ headerShown: false }} />
      <Stack.Screen name='post-list' options={{ headerShown: false }} />
      <Stack.Screen name='update-post' options={{ headerShown: false }} />
    </Stack>
  )
}

export default PageLayout
